using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ReadOnlyCollection<T> : ListT<T>
    {
        public ReadOnlyCollection()
        {
        }

        public IList<T> ReadOnlyList
        {
            get => this;
        }

        public ReadOnlyCollection<T> Clone()
        {
            return new ReadOnlyCollection<T>();
        }
    }
}
