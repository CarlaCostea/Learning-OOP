using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ObjectArrayEnumerator : IEnumerator
    {
        readonly ObjectArray elements = new ObjectArray();
        int position = -1;

        public ObjectArrayEnumerator()
        {
        }

        public object Current => this;

        public bool MoveNext()
        {
            position++;
            return position < elements.Count;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
