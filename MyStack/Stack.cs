using System;
using static System.Console;
using System.Collections.Generic;

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
        // push elements into the stack
        public void Push(int elem)
        {
            StackNode newNode = new StackNode(elem);
            newNode.next = head;
            head = newNode;
        }
        public bool IsEmpty()
        {
            return Size() == 0;
        }
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
        public int Peek()
        {
            if(IsEmpty())
            {
                throw new Exception(message: "The stack is Empty!");
            }
            return head.data;
        }
        public void Pop()
        {
            StackNode temp;
            if(IsEmpty())
            {
                throw new Exception(message: "The stack is Empty!");
            }
            temp = head;
            head = head.next;
            temp = null;
        }
    }
}