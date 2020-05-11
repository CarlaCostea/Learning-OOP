using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
            List = null;
        }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Data { get; set; }

        public CircularDoublyLinkedList<T> List { get; set; }

        public void Connect(Node<T> previous = null, Node<T> next = null)
            {
            if (previous != null)
            {
                Previous = previous;
            }

            if (next == null)
            {
                return;
            }

            Next = next;
        }
    }
}
