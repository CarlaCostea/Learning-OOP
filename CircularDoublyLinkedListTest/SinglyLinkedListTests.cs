using CircularDoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircularDoublyLinkedListTest
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void TestCountElementsInList()
        {
            SinglyLinkedList intList = new SinglyLinkedList();
            intList.InsertFront(3);
            intList.InsertFront(2);
            intList.InsertFront(1);
            intList.InsertFront(0);
            Assert.Equal(4, intList.Count);


        }
    }
}
