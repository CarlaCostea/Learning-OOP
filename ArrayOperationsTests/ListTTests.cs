using ArrayOperations;
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
            Assert.True(intArray.Contains(2));
            Assert.Equal(1, intArray.IndexOf(2));
        }

        [Fact]
        public void AddIntElementsAndTestEnumerator()
        {
            var intArray = new ListT<int>() { 1, 2, 3, 4 };
            intArray.Add(5);
            Assert.Equal(5, intArray.Count);
            Assert.True(intArray.Contains(2));
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
            Assert.True(charArray.Contains('b'));
            Assert.Equal(1, charArray.IndexOf('b'));
        }

        [Fact]
        public void AddCharElementsAndTestEnumerator()
        {
            var charArray = new ListT<char>() { 'a', 'b', 'c', 'd' };
            charArray.Add('e');
            Assert.Equal(5, charArray.Count);
            Assert.True(charArray.Contains('b'));
            Assert.Equal(1, charArray.IndexOf('b'));
            var enumerate = charArray.GetEnumerator();
            Assert.True(enumerate.MoveNext());
            Assert.Equal(1, enumerate.Current);
        }
    }
}
