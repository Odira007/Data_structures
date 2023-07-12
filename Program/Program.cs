using System;
using static System.Console;
using DataStructures.MyStack;
using DataStructures.MyQueue;
using DataStructures.MyLinkedList;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        Queue queue = new Queue();
        LinkedList list = new LinkedList();
        // list.Add(4);
        // list.Add(2);
        // list.Add(9);
        // list.Add(1);
        // WriteLine(list.Size());
        // WriteLine(list.Index(0));
        // list.Add(6);
        // list.Add(8);

        stack.Push(5);
        stack.Push(3);
        stack.Push(4);
        WriteLine(stack.Peek());
        WriteLine(stack.Size());
    }
}
