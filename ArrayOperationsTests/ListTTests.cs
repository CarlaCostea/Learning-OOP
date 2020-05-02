using ArrayOperations;
using System;
using Xunit;

namespace ArrayOperationsTests
{
    public class ListTTests
    {
        [Fact]
        public void AddIntElementsAndTestPossibleMethods()
        {
            var intArray = new ListT<int>() { 1, 2, 3, 4 };
            intArray.Add(5);
            Assert.Equal(5, intArray.Count);
            Assert.Contains(2, intArray);
            Assert.Equal(1, intArray.IndexOf(2));
        }

        [Fact]
        public void AddIntElementsAndTestEnumerator()
        {
            var intArray = new ListT<int>() { 1, 2, 3, 4 };
            intArray.Add(5);
            Assert.Equal(5, intArray.Count);
            Assert.Contains(2, intArray);
            Assert.Equal(1, intArray.IndexOf(2));
            var enumerate = intArray.GetEnumerator();
            Assert.True(enumerate.MoveNext());
            Assert.Equal(1, enumerate.Current);
        }

        [Fact]
        public void AddCharElementsAndTestPossibleMethods()
        {
            var charArray = new ListT<char>() { 'a', 'b', 'c', 'd' };
            charArray.Add('e');
            Assert.Equal(5, charArray.Count);
            Assert.Contains('b', charArray);
            Assert.Equal(1, charArray.IndexOf('b'));
        }

        [Fact]
        public void AddCharElementsAndTestEnumerator()
        {
            var charArray = new ListT<char>() { 'a', 'b', 'c', 'd' };
            charArray.Add('e');
            Assert.Equal(5, charArray.Count);
            Assert.Contains('b', charArray);
            Assert.Equal(1, charArray.IndexOf('b'));
            var enumerate = charArray.GetEnumerator();
            Assert.True(enumerate.MoveNext());
            Assert.Equal('a', enumerate.Current);
        }

        [Fact]
        public void RemoveElementsAndValidateRemainingElements()
        {
            var stringArray = new ListT<string>() { "red", "red", "blue", "black" };
            stringArray.Add("green");
            Assert.Equal(5, stringArray.Count);
            Assert.Contains("red", stringArray);
            Assert.Equal(2, stringArray.IndexOf("blue"));
            Assert.True(stringArray.Remove("red"));
            var enumerate = stringArray.GetEnumerator();
            Assert.True(enumerate.MoveNext());
            Assert.Equal("red", enumerate.Current);
            Assert.Equal(4, stringArray.Count);
        }

        [Fact]
        public void CopyElementsInTheSameDimensionArray()
        {
            var stringArray = new ListT<string>() { "red", "red", "blue", "black" };
            stringArray.Add("green");
            string[] clone = new string[8];
            stringArray.CopyTo(clone, 0);
            Assert.Equal(stringArray[0], clone[0]);
            Assert.Equal(stringArray[1], clone[1]);
            Assert.Equal(stringArray[2], clone[2]);
        }


        [Fact]
        public void CopyElementsInSmallerDimensionArrayShouldTrowAnError()
        {
            var stringArray = new ListT<string>() { "red", "red", "blue", "black" };
            stringArray.Add("green");
            string[] clone = new string[3];
            Assert.Throws<ArgumentException>(() => stringArray.CopyTo(clone, 0));
        }


        [Fact]
        public void SetElementsOnAReadOnlyListShouldTrowAnError()
        {
            var stringArray = new ListT<string>() { "red", "red", "blue", "black" };
            stringArray.IsReadOnly = true;
            Assert.Throws<NotSupportedException>(() => stringArray[0] = "white");
        }
    }
}