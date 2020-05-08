using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class SinglyLinkedList
    {
        public NodeSingly Head;

        public void InsertFront(SinglyLinkedList singlyList, int newData)
        {
            NodeSingly newNode = new NodeSingly(newData);
            newNode.Next = singlyList.Head;
            singlyList.Head = newNode;
        }
    }
}
