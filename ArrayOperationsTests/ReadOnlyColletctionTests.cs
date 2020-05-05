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
