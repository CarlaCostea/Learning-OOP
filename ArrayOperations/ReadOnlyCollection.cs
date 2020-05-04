using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ReadOnlyCollection<T> : IList<T>
    {
        const string IsReadOnlyError = "List is ReadOnly";
        private ListT<T> readonlyList;

        public ReadOnlyCollection(ListT<T> readonlyList)
        {
            this.readonlyList = readonlyList;
        }

        public int Count { get; set; }

        public bool IsReadOnly { get; }

        public virtual T this[int index]
        {
            get => readonlyList[index];
            set
            {
                    throw new NotSupportedException(IsReadOnlyError);
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return readonlyList[i];
            }
        }

        public virtual void Add(T item)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(readonlyList[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        public virtual void Insert(int index, T item)
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
            if (array == null)
            {
                throw new ArgumentException("Array Cannot be null");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Index can't be less than 0");
            }

            if (array.Length - arrayIndex >= Count)
            {
                return;
            }

            throw new ArgumentException("The number of elements in List is greater than the available space from" + nameof(arrayIndex) + "to the end of the destination array");
        }

        public void RemoveAllElementsWithGivenValue(T value)
        {
            throw new NotSupportedException(IsReadOnlyError);
        }
    }
}
