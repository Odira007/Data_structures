using System;

namespace DataStructures.MyStack
{
    public class Stack
    {
        private StackNode head = null;
        private class StackNode
        {
            public int data;
            public StackNode next;
            public StackNode() {}
            public StackNode(int _data)
            {
                this.data = _data;
            }
        }
        public Stack(){}
        
        /// <summary>
        /// adds an item to the top of the stack
        /// </summary>
        /// <param name="elem">The item to be added to the stack</param>
        public void Push(int elem)
        {
            StackNode newNode = new StackNode(elem);
            newNode.next = head;
            head = newNode;
        }

        /// <summary>
        /// Checks if the stack is empty
        /// </summary>
        /// <returns>returns true if the stack is empty and false is it isn’t</returns>
        public bool IsEmpty()
        {
            return Size() == 0;
        }

        /// <summary>
        /// Get the number of items currently in the stack
        /// </summary>
        /// <returns>Returns number of items in the stack</returns>
        public int Size()
        {
            int count = 1;
            StackNode current = head;
            if (current == null)
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

        /// <summary>
        /// Gets the item at the top of the stack
        /// </summary>
        /// <returns>Returns the last item added to the stack</returns>
        public int Peek()
        {
            if(IsEmpty())
            {
                throw new Exception(message: "The stack is Empty!");
            }
            return head.data;
        }

        /// <summary>
        /// Removes and returns the last item added to the stack
        /// </summary>
        /// <returns>Returns the last item added to the stack</returns>
        public int Pop()
        {
            StackNode temp;
            if(IsEmpty())
            {
                throw new Exception(message: "The stack is Empty!");
            }
            temp = head;
            head = head.next;
            return temp.data;
        }
    }
}