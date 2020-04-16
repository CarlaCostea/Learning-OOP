using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayOperationsTests
{
    public class SortedIntArrayTests
    {
        [Fact]
        public void AddNumberToArray()
        {
            SortedIntArray intArray = new SortedIntArray();
            intArray.Add(7);
            intArray.Add(5);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Add(2);
            intArray.Add(6);
            intArray.Add(8);
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(test.Length, intArray.Count);
            Assert.Equal(2, intArray[0]);
            Assert.Equal(3, intArray[1]);
            Assert.Equal(4, intArray[2]);
            Assert.Equal(5, intArray[3]);
            Assert.Equal(6, intArray[4]);
            Assert.Equal(7, intArray[5]);
            Assert.Equal(8, intArray[6]);
        }
    }
}
