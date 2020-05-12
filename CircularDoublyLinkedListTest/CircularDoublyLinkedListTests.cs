using CircularDoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircularDoublyLinkedListTest
{
    public class CircularDoublyLinkedListTests
    {
        [Fact]
        public void TestCount()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(0);
            Assert.Equal(3, circularDoublyLinkedList.Count);
        }
    }
}
