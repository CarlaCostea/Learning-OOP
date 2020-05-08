using CircularDoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircularDoublyLinkedListTest
{
    public class DoublyLinkedListTests
    {
        [Fact]

        public void AddNewDataInFrontOfTheList()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.InsertFront(9);
            doublyLinkedList.InsertFront(8);
            DoublyLinkedList secondDoublyLinkedList = new DoublyLinkedList();
            secondDoublyLinkedList.InsertFront(8);
            Assert.Equal(secondDoublyLinkedList.Head, doublyLinkedList.Head);
        }
    }
}
