using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ReadOnlyCollection<T> : ListT<T>
    {
        private ListT<T> readonlyElements;

        public ReadOnlyCollection(ListT<T> elements)
        {
            readonlyElements = elements;
        }

        public IList<T> ReadOnlyList
        {
            get => readonlyElements;
        }

        public ReadOnlyCollection<T> Clone()
        {
            return new ReadOnlyCollection<T>(readonlyElements);
        }
    }
}
