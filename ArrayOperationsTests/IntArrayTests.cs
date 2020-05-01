using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayOperationsTests
{
    public class IntArrayTests
    {
        [Fact]
        public void AddNumberToArray()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray.Add(6);
            intArray.Add(7);
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(test.Length, intArray.Count);
        }

        [Fact]
        public void ReturnElementFromIndex()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            Assert.Equal(3, intArray[2]);
        }

        [Fact]
        public void SetElementFromIndex()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray[2] =10;
            Assert.Equal(10, intArray[2]);
        }


        [Fact]
        public void IfArrayContainsElementWeShouldReturnTrue()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray[2] = 10;
            Assert.True(intArray.Contains(10));
        }

        [Fact]
        public void IfArrayDoesNotContainElementWeShouldReturnFalse()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray[2] = 10;
            Assert.False(intArray.Contains(11));
        }

        [Fact]
        public void IfArrayContainsElementWeShouldReturnIndexElseReturnMinusOne()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray[2] = 10;
            Assert.Equal(2, intArray.IndexOf(10));
            Assert.Equal(-1, intArray.IndexOf(11));
        }

        [Fact]
        public void InsertElementAtPosition()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            Assert.Equal(5, intArray.Count);
            intArray.Insert(2, 10);
            Assert.Equal(2, intArray.IndexOf(10));
            Assert.Equal(3, intArray[3]);
            Assert.Equal(6, intArray.Count);
        }

        [Fact]
        public void ClearArray()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray.Clear();
            Assert.Equal(0, intArray.Count);
        }

        [Fact]
        public void RemoveFirstOccurenceOfElementAndValidateTheRemainingElements()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(2);
            intArray.Add(5);
            intArray.Add(2);

            Assert.Equal(1, intArray.IndexOf(2));

            intArray.Remove(2);
            
            Assert.Equal(5, intArray.Count);
            Assert.True(intArray[1] == 3);
            Assert.True(intArray[2] == 2);
            Assert.True(intArray[4] == 2);
        }

        [Fact]
        public void RemoveElementAtIndex()
        {
            IntArray intArray = new IntArray();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(5);
            intArray.RemoveAt(2);
            Assert.Equal(4, intArray.Count);
            Assert.Equal(-1, intArray.IndexOf(3));
        }
    }
}
