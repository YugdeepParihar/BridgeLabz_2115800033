using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public Process Next;

    public Process(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Process head = null;
    private Process tail = null;
    private int timeQuantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    // Add a new process at the end (circular list)
    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newProcess = new Process(processID, burstTime, priority);

        if (head == null)
        {
            head = newProcess;
            tail = newProcess;
            tail.Next = head; // Circular link
        }
        else
        {
            tail.Next = newProcess;
            tail = newProcess;
            tail.Next = head; // Maintain circular link
        }
        Console.WriteLine($"Process {processID} added with Burst Time: {burstTime}");
    }

    // Remove a process after execution
    private void RemoveProcess(int processID)
    {
        if (head == null)
        {
            return;
        }

        Process current = head, prev = null;
        do
        {
            if (current.ProcessID == processID)
            {
                if (current == head && current == tail) // Only one node
                {
                    head = tail = null;
                }
                else if (current == head) // Remove head
                {
                    head = head.Next;
                    tail.Next = head;
                }
                else if (current == tail) // Remove tail
                {
                    prev.Next = head;
                    tail = prev;
                }
                else // Remove middle node
                {
                    prev.Next = current.Next;
                }
                Console.WriteLine($"Process {processID} completed and removed.");
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);
    }

    // Simulate Round Robin Scheduling
    public void ExecuteRoundRobin()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        Console.WriteLine("\nExecuting Round Robin Scheduling...");
        int totalTime = 0;
        int completedProcesses = 0;
        int waitingTimeSum = 0;
        int turnAroundTimeSum = 0;

        while (head != null)
        {
            Process current = head;
            do
            {
                if (current.BurstTime > 0)
                {
                    int executionTime = Math.Min(timeQuantum, current.BurstTime);
                    current.BurstTime -= executionTime;
                    totalTime += executionTime;

                    if (current.BurstTime == 0) // Process completed
                    {
                        turnAroundTimeSum += totalTime; // Turnaround Time = Completion Time
                        waitingTimeSum += totalTime - executionTime; // Waiting Time
                        int completedID = current.ProcessID;
                        RemoveProcess(completedID);
                        completedProcesses++;
                    }
                }
                current = current.Next;
            } while (current != head);

            DisplayProcesses();
        }

        // Calculate and display average waiting time and turnaround time
        double avgWaitingTime = (double)waitingTimeSum / completedProcesses;
        double avgTurnaroundTime = (double)turnAroundTimeSum / completedProcesses;
        Console.WriteLine($"\nAverage Waiting Time: {avgWaitingTime:F2}");
        Console.WriteLine($"Average Turnaround Time: {avgTurnaroundTime:F2}");
    }

    // Display the list of processes
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Console.WriteLine("\nCurrent Process Queue:");
        Process temp = head;
        do
        {
            Console.WriteLine($"Process ID: {temp.ProcessID}, Remaining Burst Time: {temp.BurstTime}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(3); // Time Quantum = 3

        // Adding processes
        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);
        scheduler.AddProcess(4, 6, 2);

        // Display initial process queue
        scheduler.DisplayProcesses();

        // Execute Round Robin Scheduling
        scheduler.ExecuteRoundRobin();
    }
}
