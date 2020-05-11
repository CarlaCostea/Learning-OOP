using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class DoublyNode
    {
        public DoublyNode(int d)
        {
            this.Data = d;
            this.Previous = null;
            this.Next = null;
        }

        public int Data { get; set; }

        public DoublyNode Next { get; set; }

        public DoublyNode Previous { get; set; }
    }
}