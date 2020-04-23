using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ObjectArrayEnumerator : IEnumerator
    {
        private readonly object[] elements;
        private readonly int count;
        int position = -1;

        public ObjectArrayEnumerator(object[] elements, int count)
        {
            this.elements = elements;
            this.count = count;
        }

        public object Current => elements[position];

        public bool MoveNext()
        {
            position++;
            return position < count;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
