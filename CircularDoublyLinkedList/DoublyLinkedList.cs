using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public DoublyNode Head;

        public DoublyLinkedList DoubleLinkedList;

        public void InsertFront(int newData)
        {
            DoublyNode newNode = new DoublyNode(newData);
            newNode.Next = DoubleLinkedList.Head.Previous;
            newNode.Previous = null;
            if (DoubleLinkedList.Head != null)
            {
                DoubleLinkedList.Head.Previous = newNode.Next;
            }

            DoubleLinkedList.Head = newNode;
        }
    }
}
