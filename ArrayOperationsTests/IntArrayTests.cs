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
            int[] test = new int[] { 1, 2, 3 };
            Assert.Equal(test.Length, intArray.Count());
        }
    }
}
