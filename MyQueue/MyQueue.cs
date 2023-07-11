using System;
using static System.Console;

namespace DataStructures.MyQueue
{
    public class Queue
    {
        private QueueNode head = null;
        private QueueNode tail = null;
        public class QueueNode
        {
            public int data;
            public QueueNode next;
            public QueueNode(){}
            public QueueNode(int _data)
            {
                this.data = _data;
            }
        }

        public bool IsEmpty()
        {
            return head == null & tail == null;
        }

        public void Enqueue(int elem)
        {
            QueueNode newNode = new QueueNode(elem);
            newNode.next = tail;
            if (Size() == 1)
            {
                tail = head = newNode;
            }
            tail = newNode;
            
        }

        public void Dequeue()
        {
            if(Size() == 0)
            {
                WriteLine("The stack is empty!");
            }
            QueueNode current = tail;
            
        }
        public int Size()
        {
            QueueNode current = new QueueNode();
            int count = 1;
            current = tail;
            if (current == null & head == null)
            {
                return 0;
            }
            while(current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }
    }
}

