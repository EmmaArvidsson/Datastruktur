using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    class LinkedList<T>
    {

        private Node head;

        public void AddFirst (int value)
        {
            Node toAdd = new Node();
            toAdd.value = value;
            toAdd.next = head;

            head = toAdd;

        }

        public void AddLast (int value)
        {
            if (head == null)
            {
                head = new Node();

                head.value = value;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.value = value;
                
                    Node current = head;
                while (current.next != null)
                {
                    current = current.next;

                }
                current.next = toAdd;
            }

        }

        public void RemoveFirst ()
        {

        }

        public void RemoveLast ()
        {

        }

        public void RemoveValue (int value)
        {

        }

        public void FindValue (int value )
        {

        }

        public void PrintList ()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        } 
    }
}
