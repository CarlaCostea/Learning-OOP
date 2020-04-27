using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArrayOperationsTests
{
    public class ObjectArrayEnumeratorTests
    {
        [Fact]

        public void TestIenumerator()
        {
            ObjectArray objectArray = new ObjectArray
            {
                1,
                2
            };
            var arrayEnumerator = objectArray.GetEnumeratorForExternalClass();
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal(1, arrayEnumerator.Current);
            Assert.True(arrayEnumerator.MoveNext());
            Assert.Equal(2, arrayEnumerator.Current);
            Assert.False(arrayEnumerator.MoveNext());

        }
    }
}
