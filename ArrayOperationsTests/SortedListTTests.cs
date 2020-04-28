using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayOperationsTests
{
    public class SortedListTTests
    {
        [Fact]
        public void TestOrderOfElements()
        {
            var sortedList = new SortedListT<int> () { 5, 3, 7, 1, 9 };
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(3, sortedList[1]);
            Assert.Equal(9, sortedList[4]);
        }

        [Fact]
        public void ValidInsertionOfNewElementAtGivenPosition()
        {
            var sortedList = new SortedListT<int>() { 5, 3, 7, 1, 9 };
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(3, sortedList[1]);
            Assert.Equal(9, sortedList[4]);
            sortedList.Insert(0, 0);
            Assert.Equal(0, sortedList.IndexOf(0));
            Assert.Equal(9, sortedList[5]);
        }

        [Fact]
        public void InvalidInsertionOfNewElementAtGivenPosition()
        {
            var sortedList = new SortedListT<int>() { 5, 3, 7, 1, 9 };
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(3, sortedList[1]);
            Assert.Equal(9, sortedList[4]);
            sortedList.Insert(100, 0);
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(9, sortedList[4]);
        }

        [Fact]
        public void ValidSetOfNewValueAtGivenPosition()
        {
            var sortedList = new SortedListT<int>() { 5, 3, 7, 1, 9 };
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(3, sortedList[1]);
            Assert.Equal(9, sortedList[4]);
            sortedList[0] = 0;
            Assert.Equal(0, sortedList.IndexOf(0));
            Assert.Equal(-1, sortedList.IndexOf(1));
            Assert.Equal(9, sortedList[4]);
        }

        [Fact]
        public void InvalidSetOfNewValueAtGivenPosition()
        {
            var sortedList = new SortedListT<int>() { 5, 3, 7, 1, 9 };
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(3, sortedList[1]);
            Assert.Equal(9, sortedList[4]);
            sortedList[0] = 1000;
            Assert.Equal(0, sortedList.IndexOf(1));
            Assert.Equal(9, sortedList[4]);
        }

        [Fact]
        public void AddIntElementsAndTestEnumerator()
        {
            var intArray = new SortedListT<int>() { 5, 3, 7, 1, 9 };
            Assert.Equal(5, intArray.Count);
            Assert.False(intArray.Contains(2));
            Assert.Equal(-1, intArray.IndexOf(2));
            var enumerate = intArray.GetEnumerator();
            Assert.True(enumerate.MoveNext());
            Assert.Equal(1, enumerate.Current);
        }
    }
}
