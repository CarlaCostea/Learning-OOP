using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class Node
    {

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public int Data { get; set; }

        public Node Next { get; set; }
    }
}
