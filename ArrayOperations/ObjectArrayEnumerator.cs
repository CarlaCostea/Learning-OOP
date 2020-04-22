using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    internal class ObjectArrayEnumerator : IEnumerator
    {
        private readonly object[] elements;
        int position = -1;

        public ObjectArrayEnumerator()
        {
            const int initialSize = 4;
            elements = new object[initialSize];
        }

        public object Current => this;

        public bool MoveNext()
        {
            position++;
            return position < elements.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
