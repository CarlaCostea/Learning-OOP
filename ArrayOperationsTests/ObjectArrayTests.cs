﻿using ArrayOperations;
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
            ObjectArray objectArray = new ObjectArray
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(test.Length, objectArray.Count);
        }

        [Fact]
        public void TestContainsMethod()
        {
            ObjectArray objectArray = new ObjectArray
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
            int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(test.Length, objectArray.Count);
            Assert.True(objectArray.Contains(2));
        }

        [Fact]
        public void TestAllMethods()
        {
            ObjectArray objectArray = new ObjectArray
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
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

        [Fact]
        public void TestEnumerator()
        {
            ObjectArray objectArray = new ObjectArray
            {
                1,
                2,
                3
            };

            Assert.Equal(3, objectArray.Count);

            Assert.True(objectArray.Contains(2));

            var arrayEnumerator = objectArray.GetEnumerator();
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal(1, arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal(2, arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal(3, arrayEnumerator.Current);
            Assert.False(arrayEnumerator.MoveNext());
        }

        [Fact]
        public void MoveNextShouldReturnTrueIfWeHaveAvailableElements()
        {
            ObjectArray objectArray = new ObjectArray { "first", "second", "last" };

            Assert.Equal(3, objectArray.Count);

            Assert.True(objectArray.Contains("second"));

            var arrayEnumerator = objectArray.GetEnumerator();
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal("first", arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal("second", arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal("last", arrayEnumerator.Current);
            Assert.False(arrayEnumerator.MoveNext());
        }

        [Fact]
        public void MoveNextShouldReturnFalseIfWeDontHaveAvailableElements()
        {
            ObjectArray objectArray = new ObjectArray { "first", "second", "last" };

            Assert.Equal(3, objectArray.Count);

            Assert.True(objectArray.Contains("second"));

            var arrayEnumerator = objectArray.GetEnumerator();
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal("first", arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal("second", arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal("last", arrayEnumerator.Current);
            Assert.False(arrayEnumerator.MoveNext());
            Assert.False(arrayEnumerator.MoveNext());
        }
    }
}
