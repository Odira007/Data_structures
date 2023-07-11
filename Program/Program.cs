using System;
using static System.Console;
using DataStructures.MyStack;
using DataStructures.MyQueue;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        Queue queue = new Queue();
        queue.Enqueue(3);
        queue.Enqueue(3);
        queue.Enqueue(3);
        queue.Enqueue(3);
        WriteLine(queue.Size());
        WriteLine(queue.IsEmpty());
        queue.Dequeue();
        queue.Dequeue();
        WriteLine(queue.Size());

    }
}
