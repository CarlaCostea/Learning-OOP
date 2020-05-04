using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ArrayOperations
{
    public class ReadOnlyCollection<T> : ListT<T>
    {
        public ReadOnlyCollection(ListT<T> elements)
        {
            _ = elements.ToImmutableList();
        }
    }
}
