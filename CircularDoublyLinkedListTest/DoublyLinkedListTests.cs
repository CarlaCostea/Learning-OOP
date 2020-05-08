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
            doublyLinkedList.InsertFront(doublyLinkedList, 9);
            doublyLinkedList.InsertFront(doublyLinkedList, 8);
            DoublyLinkedList secondDoublyLinkedList = new DoublyLinkedList();
            secondDoublyLinkedList.InsertFront(secondDoublyLinkedList, 8);
            Assert.Equal(secondDoublyLinkedList.Head, doublyLinkedList.Head);
        }
    }
}
