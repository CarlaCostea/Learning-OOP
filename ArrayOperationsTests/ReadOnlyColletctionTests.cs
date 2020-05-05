using ArrayOperations;
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

        public void TryingToClearTheReadonlyListShouldTrowAnError()
        {
            var list = new ListT<int> { 0, 1, 2, 3 };
            ReadOnlyCollection<int> readOnlyList = new ReadOnlyCollection<int>(list);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
            Assert.Throws<NotSupportedException>(() => readOnlyList.Clear());
            Assert.False(readOnlyList.Count == 0);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
        }

        [Fact]

        public void CopyElementsInNewListShouldBeAvailable()
        {
            var list = new ListT<int> { 0, 1, 2, 3 };
            ReadOnlyCollection<int> readOnlyList = new ReadOnlyCollection<int>(list);
            Assert.Equal(new[] { 0, 1, 2, 3 }, readOnlyList);
            int[] listClone = new int[readOnlyList.Count];
            readOnlyList.CopyTo(listClone, 0);
            Assert.Equal(new[] { 0, 1, 2, 3 }, listClone);
        }


        [Fact]
        public void AddingElementsInListShouldAddThemInReadOnlyList()
        {
            var stringArray = new ListT<string>() { "red", "red", "red" };
            ReadOnlyCollection<string> readOnlyStringArray = new ReadOnlyCollection<string>(stringArray);
            Assert.Equal(3, readOnlyStringArray.Count);
            Assert.Equal(new[] { "red", "red", "red" }, readOnlyStringArray);
            stringArray.Add("black");
            Assert.Equal(new[] { "red", "red", "red", "black" }, readOnlyStringArray);
            Assert.Equal(4, readOnlyStringArray.Count);
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
