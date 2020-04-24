using System.Collections;

namespace ArrayOperations
{
    public class ObjectArrayEnumerator : IEnumerator
    {
        private readonly ObjectArray objectArray;
        int position = -1;

        public ObjectArrayEnumerator(ObjectArray objectArray)
        {
            this.objectArray = objectArray;
        }

        public object Current => objectArray[position];

        public bool MoveNext()
        {
            position++;
            return position < objectArray.Count;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
