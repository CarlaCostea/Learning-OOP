﻿using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayOperationsTests
{
    public class ReadOnlyColletctionTests
    {

        [Fact]
        public void CountElementsInReadonlyList()
        {
            var stringArray = new ListT<string>() { "red", "red", "red" };
            ReadOnlyCollection<string> readOnlyStringArray = new ReadOnlyCollection<string>(stringArray);
            Assert.Equal(3, readOnlyStringArray.Count);
        }

        [Fact]

        public void EnumerateReadOnlyListElements()
        {
            var list = new ListT<int> { 0, 1, 2, 3 };
            ReadOnlyCollection<int> readOnlyList = new ReadOnlyCollection<int>(list);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
        }

        [Fact]

        public void TryingToAddAnElementInReadonlyListShoulTrowAnError()
        {
            var list = new ListT<int> { 0, 1, 2, 3 };
            ReadOnlyCollection<int> readOnlyList = new ReadOnlyCollection<int>(list);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
            Assert.Throws<NotSupportedException>(() => readOnlyList.Add(4));
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
        }

        [Fact]

        public void TryingToRemoveAnElementFromReadonlyListShoulTrowAnError()
        {
            var list = new ListT<int> { 0, 1, 2, 3 };
            ReadOnlyCollection<int> readOnlyList = new ReadOnlyCollection<int>(list);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
            Assert.Throws<NotSupportedException>(() => readOnlyList.Remove(2));
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
        }

        [Fact]

        public void TryingToClearTheReadonlyListShoulTrowAnError()
        {
            var list = new ListT<int> { 0, 1, 2, 3 };
            ReadOnlyCollection<int> readOnlyList = new ReadOnlyCollection<int>(list);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
            Assert.Throws<NotSupportedException>(() => readOnlyList.Clear());
            Assert.False(readOnlyList.Count == 0);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
        }

        [Fact]
        public void RemoveAllElementsWithGivenValueIfListIsReadonly()
        {
            var stringArray = new ListT<string>() { "red", "red", "red" };
            ReadOnlyCollection<string> readOnlyStringArray = new ReadOnlyCollection<string>(stringArray);
            Assert.Equal(3, readOnlyStringArray.Count);
            Assert.Throws<NotSupportedException>(() => readOnlyStringArray.RemoveAllElementsWithGivenValue("red"));
            Assert.False(readOnlyStringArray.IndexOf("red") == -1);
        }

    }
}
