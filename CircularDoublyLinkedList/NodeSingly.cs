using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class NodeSingly
    {
        public NodeSingly(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public int Data { get; set; }

        public NodeSingly Next { get; set; }
    }
}
