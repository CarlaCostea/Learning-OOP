using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public DoublyNode Head;

        public void InsertFront(DoublyLinkedList doublyLinkedList, int newData)
        {
            DoublyNode newNode = new DoublyNode(newData);
            newNode.Next = doublyLinkedList.Head.Previous;
            newNode.Previous = null;
            if (doublyLinkedList.Head != null)
            {
                doublyLinkedList.Head.Previous = newNode.Next;
            }

            doublyLinkedList.Head = newNode;
        }
    }
}
