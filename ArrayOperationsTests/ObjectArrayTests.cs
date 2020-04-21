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
        public void AddObjectToArray()
        {
            ObjectArray objectArray = new ObjectArray();
            objectArray.Add(1);
            objectArray.Add(2);
            objectArray.Add(3);
            objectArray.Add(4);
            objectArray.Add(5);
            objectArray.Add(6);
            objectArray.Add(7);
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(test.Length, objectArray.Count);
        }

        [Fact]
        public void TestContainsMethod()
        {
            ObjectArray objectArray = new ObjectArray();
            objectArray.Add(1);
            objectArray.Add(2);
            objectArray.Add(3);
            objectArray.Add(4);
            objectArray.Add(5);
            objectArray.Add(6);
            objectArray.Add(7);
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(test.Length, objectArray.Count);
            Assert.True(objectArray.Contains(2));
        }
    }
}
