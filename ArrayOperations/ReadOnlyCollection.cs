using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ReadOnlyCollection<T> : IList<T>
    {
        const string IsReadOnlyError = "List is ReadOnly";
        private readonly IList<T> readonlyList;

        public ReadOnlyCollection(IList<T> list)
        {
            this.readonlyList = list;
        }

        public int Count
        {
            get => readonlyList.Count;
        }

        public bool IsReadOnly => true;

        public T this[int index]
        {
            get => readonlyList[index];
            set
            {
                    throw new NotSupportedException(IsReadOnlyError);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return readonlyList.GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }

        public bool Contains(T item)
        {
            return readonlyList.Contains(item);
        }

        public int IndexOf(T item)
        {
            return readonlyList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)readonlyList).GetEnumerator();
        }

        public void Clear()
        {
            throw new NotSupportedException(IsReadOnlyError);
        }

        public bool Remove(T item)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }

        public void RemoveAt(int index)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            readonlyList.CopyTo(array, arrayIndex);
        }

        public void RemoveAllElementsWithGivenValue(T value)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }
    }
}
