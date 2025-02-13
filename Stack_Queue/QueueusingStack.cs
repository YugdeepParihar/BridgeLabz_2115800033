using System;

class QueueUsingStacks
{
    private int[] stack1;
    private int[] stack2;
    private int top1;
    private int top2;
    private int size;

    public QueueUsingStacks(int capacity)
    {
        size = capacity;
        stack1 = new int[size];
        stack2 = new int[size];
        top1 = -1;
        top2 = -1;
    }

    public void Enqueue(int item)
    {
        if (top1 == size - 1)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        stack1[++top1] = item;
    }

    public int Dequeue()
    {
        if (top1 == -1 && top2 == -1)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        if (top2 == -1)
        {
            while (top1 >= 0)
            {
                stack2[++top2] = stack1[top1--];
            }
        }
        return stack2[top2--];
    }

    public bool IsEmpty()
    {
        return top1 == -1 && top2 == -1;
    }

    public int Peek()
    {
        if (top1 == -1 && top2 == -1)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        if (top2 == -1)
        {
            while (top1 >= 0)
            {
                stack2[++top2] = stack1[top1--];
            }
        }
        return stack2[top2];
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); // Output: 1
        Console.WriteLine(queue.Dequeue()); // Output: 2

        queue.Enqueue(4);
        Console.WriteLine(queue.Peek()); // Output: 3
    }
}
