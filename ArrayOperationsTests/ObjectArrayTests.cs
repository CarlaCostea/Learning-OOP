using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayOperationsTests
{
    public class ObjectArrayTests
    {
        [Fact]
        public void AddObjecyToArray()
        {
            ObjectArray intArray = new ObjectArray();
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
    }
}
