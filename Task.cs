using System;

class Task {
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Task next;

    public Task(int taskID, string taskName, int priority, DateTime dueDate) {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        next = null;
    }
}

class TaskScheduler {
    private Task head = null;
    private Task tail = null;
    private Task currentTask = null;

    // Add a task at the beginning
    public void AddTaskAtStart(int taskID, string taskName, int priority, DateTime dueDate) {
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (head == null) {
            head = tail = newTask;
            tail.next = head;  // Circular link
        } else {
            newTask.next = head;
            head = newTask;
            tail.next = head;  // Maintain circular link
        }
    }

    // Add a task at the end
    public void AddTaskAtEnd(int taskID, string taskName, int priority, DateTime dueDate) {
        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (head == null) {
            head = tail = newTask;
            tail.next = head;  // Circular link
        } else {
            tail.next = newTask;
            tail = newTask;
            tail.next = head;  // Maintain circular link
        }
    }

    // Add a task at a specific position
    public void AddTaskAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position) {
        if (position < 1) {
            Console.WriteLine("Invalid position!");
            return;
        }

        Task newTask = new Task(taskID, taskName, priority, dueDate);
        if (position == 1) { // Insert at head
            AddTaskAtStart(taskID, taskName, priority, dueDate);
            return;
        }

        Task temp = head;
        for (int i = 1; temp != tail && i < position - 1; i++) {
            temp = temp.next;
        }

        if (temp == tail) {
            AddTaskAtEnd(taskID, taskName, priority, dueDate);
            return;
        }

        newTask.next = temp.next;
        temp.next = newTask;
    }

    // Remove a task by Task ID
    public void RemoveTaskByID(int taskID) {
        if (head == null) {
            Console.WriteLine("No tasks found!");
            return;
        }

        Task temp = head, prev = null;

        do {
            if (temp.TaskID == taskID) {
                if (temp == head) {  // Deleting head
                    head = head.next;
                    tail.next = head;
                } else if (temp == tail) {  // Deleting tail
                    tail = prev;
                    tail.next = head;
                } else {  // Deleting a middle node
                    prev.next = temp.next;
                }

                Console.WriteLine($"Task with ID {taskID} removed.");
                return;
            }

            prev = temp;
            temp = temp.next;
        } while (temp != head);

        Console.WriteLine("Task ID not found!");
    }

    // View the current task and move to the next task
    public void ViewCurrentTask() {
        if (currentTask == null) {
            currentTask = head;
        }

        if (currentTask == null) {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine($"Current Task: ID {currentTask.TaskID}, Name: {currentTask.TaskName}, Priority: {currentTask.Priority}, Due Date: {currentTask.DueDate}");
        currentTask = currentTask.next;  // Move to next task in circular manner
    }

    // Display all tasks in the list
    public void DisplayTasks() {
        if (head == null) {
            Console.WriteLine("No tasks available.");
            return;
        }

        Task temp = head;
        Console.WriteLine("Task List:");
        do {
            Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
            temp = temp.next;
        } while (temp != head);
    }

    // Search for a task by Priority
    public void SearchTaskByPriority(int priority) {
        if (head == null) {
            Console.WriteLine("No tasks available.");
            return;
        }

        Task temp = head;
        bool found = false;

        do {
            if (temp.Priority == priority) {
                Console.WriteLine($"Found - ID: {temp.TaskID}, Name: {temp.TaskName}, Due Date: {temp.DueDate}");
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found) {
            Console.WriteLine("No tasks found with the given priority.");
        }
    }
}

class CircularLinkedList {
    static void Main() {
        TaskScheduler scheduler = new TaskScheduler();

        // Adding tasks
        scheduler.AddTaskAtEnd(101, "Task A", 1, DateTime.Parse("2024-02-15"));
        scheduler.AddTaskAtEnd(102, "Task B", 2, DateTime.Parse("2024-02-16"));
        scheduler.AddTaskAtEnd(103, "Task C", 3, DateTime.Parse("2024-02-17"));
        scheduler.AddTaskAtStart(100, "Task X", 0, DateTime.Parse("2024-02-14"));
        scheduler.AddTaskAtPosition(104, "Task Y", 2, DateTime.Parse("2024-02-18"), 3);

        // Display tasks
        scheduler.DisplayTasks();

        // View and move through tasks
        Console.WriteLine("\nViewing tasks sequentially:");
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();

        // Searching by priority
        Console.WriteLine("\nSearching for tasks with priority 2:");
        scheduler.SearchTaskByPriority(2);

        // Removing a task
        Console.WriteLine("\nRemoving task with ID 102:");
        scheduler.RemoveTaskByID(102);

        // Display tasks after removal
        scheduler.DisplayTasks();
    }
}
