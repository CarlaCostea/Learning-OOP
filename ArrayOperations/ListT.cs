﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayOperations
{
    public class ListT<T> : IList<T>
    {
        private T[] elements;

        public ListT()
        {
            const int initialSize = 4;
            elements = new T[initialSize];
        }

        public int Count { get; set; }

        public bool IsReadOnly { get; set; }

        public virtual T this[int index]
        {
            get => elements[index];
            set
            {
                if (IsReadOnly)
                {
                    throw new NotSupportedException("List is ReadOnly");
                }

                elements[index] = value;
                    }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return elements[i];
            }
        }

        public virtual void Add(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException("List is ReadOnly");
            }

            VerifyNumberOfElements();
            elements[Count] = item;
            Count++;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(elements[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        public virtual void Insert(int index, T item)
        {
            if (index < 0 && index >= Count)
            {
                throw new InvalidOperationException("Specified index isn't valid");
            }

            VerifyNumberOfElements();
            Count++;
            ShiftRight(index);

            elements[index] = item;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        public void Clear()
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException("List is ReadOnly");
            }

            Array.Resize(ref elements, 0);
            Count = 0;
        }

        public bool Remove(T item)
            {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            if (IndexOf(item) == -1)
            {
                return false;
            }

            RemoveAt(IndexOf(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            if (IsReadOnly || index < 0 && index >= Count)
            {
                throw new InvalidOperationException("No element was found at specified index");
            }

            ShiftLeft(index);
            Count--;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentException("Array Cannot be null");
            }

            try
            {
                ((IList<T>)elements).CopyTo(array, arrayIndex);
            }
            catch
            {
                throw new ArgumentException("Cannot copy elements in a smaller array");
            }
        }

        public void RemoveAllElementsWithGivenValue(T value)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            int i = 0;
            while (i < Count)
            {
                if (object.Equals(elements[i], value))
                {
                    RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void VerifyNumberOfElements()
        {
            const int doubleLength = 2;

            if (Count != elements.Length)
            {
                return;
            }

            Array.Resize(ref elements, elements.Length * doubleLength);
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }
        }
    }
}
