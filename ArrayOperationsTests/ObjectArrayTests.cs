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

        [Fact]
        public void TestAllMethods()
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
            objectArray.Insert(0, 0);
            Assert.Equal(1, objectArray.IndexOf(1));
            objectArray.Remove(2);
            Assert.Equal(-1, objectArray.IndexOf(2));
            objectArray.RemoveAt(0);
            Assert.Equal(0, objectArray.IndexOf(1));
            objectArray.Clear();
            Assert.Equal(0, objectArray.Count);
        }
    }
}
