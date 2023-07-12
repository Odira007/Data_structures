using System;

namespace DataStructures.MyLinkedList
{
    public class LinkedList
    {
        private LinkedListNode head = null;
        public class LinkedListNode
        {
            public int data;
            public LinkedListNode next;
            public LinkedListNode() {}
            public LinkedListNode(int _data)
            {
                data = _data;
            }
        }

        /// <summary>
        /// Adds an item to the tail of the LinkedList
        /// </summary>
        /// <param name="elem">The value of the item to be added</param>
        public void Add(int elem)
        {
            LinkedListNode newNode = new LinkedListNode(elem);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = null;
            
            LinkedListNode last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
        }

        /// <summary>
        /// Remove the first occurence of an item from a list
        /// </summary>
        /// <param name="item">The value of the item to be removed</param>
        /// <returns>Return false if item is not found, true if it is</returns>
        public bool Remove(int item)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (head.data == item)
            {
                head = head.next;
                return true;
            }
            LinkedListNode first = head;
            LinkedListNode prev = null;

            while (first != null && first.data != item)
            {
                prev = first;
                first = first.next;
            }
            prev.next = first.next;
            return true;
        }

        /// <summary>
        /// Checks for a specified item in the linked list
        /// </summary>
        /// <param name="item">The value to be checked</param>
        /// <returns>Returns true if item is found, else returns false</returns>
        public bool Check(int item)
        {
            if (head == null)
            {
                return false;
            }
            LinkedListNode current = head;
            while(current != null)
            {
                if (current.data == item)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        public int Size()
        {
            int count = 1;
            if (head == null)
            {
                return 0;
            }
            LinkedListNode current = head;
            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }
        /// <summary>
        /// Get the index of an item in a Linked List
        /// </summary>
        /// <param name="elem">The value to be used to find the index</param>
        /// <returns>The index if the item if found, -1 if not</returns>
        public int Index(int elem)
        {
            int index = 0;
            if(IsEmpty())
            {
                return -1;
            }
            LinkedListNode current = head;

            while (current != null)
            {
                if (current.data == elem)
                {
                    return index;
                }
                current = current.next;
                index++;
            }
            return -1;
        }
    }
}

