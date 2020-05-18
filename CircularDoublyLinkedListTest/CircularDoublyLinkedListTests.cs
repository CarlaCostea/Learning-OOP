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

        [Fact]
        public void TestAdd()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            Assert.Equal(3, circularDoublyLinkedList.Count);
        }

        [Fact]
        public void TryingToAddAnElementInFrontOfANullNodeShouldTrowAnException()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);

            var node = new Node<int>(default);

            Assert.Throws<ArgumentNullException>(() => circularDoublyLinkedList.AddInFront(null, 10));
        }

        [Fact]
        public void ContainShouldReturnTrueIfElementIsInList()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            Assert.Contains(3, circularDoublyLinkedList);
        }

        [Fact]
        public void ContainShouldReturnFalseIfElementIsNotInList()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            Assert.DoesNotContain(7, circularDoublyLinkedList);
        }

        [Fact]
        public void GetEnumerator()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            var enumerator = circularDoublyLinkedList.GetEnumerator();

            Assert.True(enumerator.MoveNext());
            Assert.Equal(10, enumerator.Current);
            Assert.True(enumerator.MoveNext());
            Assert.Equal(5, enumerator.Current);
            Assert.True(enumerator.MoveNext());
            Assert.Equal(3, enumerator.Current);
            Assert.False(enumerator.MoveNext());

        }

        [Fact]
        public void TestCopyToArrayIfWeHaveEnoughSpaceInArray()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int> { 1, 2, 3 };
            var array = new int[circularDoublyLinkedList.Count];
            circularDoublyLinkedList.CopyTo(array, 0);
            Assert.Equal(3, circularDoublyLinkedList.Count);
            Assert.Equal(1, array[0]);
            Assert.Equal(2, array[1]);
            Assert.Equal(3, array[2]);
        }

        [Fact]
        public void CopyElementsInSmallerDimensionArrayShouldTrowAnError()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int> { 1, 2, 3 };
            var array = new int[circularDoublyLinkedList.Count - 1];
            Assert.Throws<ArgumentException>(() => circularDoublyLinkedList.CopyTo(array, 0));
        }

        [Fact]
        public void RemoveShouldReturnTrueIfElementIsRemovedFromList()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            Assert.True(circularDoublyLinkedList.Remove(3));
            Assert.DoesNotContain(3, circularDoublyLinkedList);
        }

        [Fact]
        public void RemoveShouldDeleteOnlyFirstAppearanceOfElement()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            circularDoublyLinkedList.Add(3);
            circularDoublyLinkedList.Remove(3);
            Assert.Contains(3, circularDoublyLinkedList);
            circularDoublyLinkedList.Remove(3);
            Assert.DoesNotContain(3, circularDoublyLinkedList);
        }

        [Fact]
        public void RemoveShouldThrowAnErrorIfListDoesNotContainElementOrNode()
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(10);
            circularDoublyLinkedList.Add(5);
            circularDoublyLinkedList.Add(3);
            Assert.Throws<ArgumentNullException>(() => circularDoublyLinkedList.Remove(7));
        }
    }
}
