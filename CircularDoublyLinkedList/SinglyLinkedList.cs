using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class SinglyLinkedList
    {
        int count;
        NodeSingly head;
        NodeSingly tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count => count;

        public void InsertFront(int newData)
        {
            NodeSingly newNode = new NodeSingly(newData);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.Next = this.head;
                this.head = newNode;
            }

            count++;
        }
    }
}
