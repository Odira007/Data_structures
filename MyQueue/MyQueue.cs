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

        /// <summary>
        /// Checks if the queue is empty
        /// </summary>
        /// <returns>Returns true if the queue is empty and false if it isn't</returns>
        public bool IsEmpty()
        {
            return head == null & tail == null;
        }

        /// <summary>
        /// adds an item to the tail of the queue
        /// </summary>
        /// <param name="elem">Value of the item to be added</param>
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

        /// <summary>
        /// Removes and returns the item at the head of the queue
        /// </summary>
        public void Dequeue()
        {
            if(Size() == 0)
            {
                WriteLine("The stack is empty!");
            }
            head = head.next;
            
        }

        /// <summary>
        /// Shows the number of items currently in the queue
        /// </summary>
        /// <returns>Returns the number of items in the queue</returns>
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

