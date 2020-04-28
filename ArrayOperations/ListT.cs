﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ListT<T> : IEnumerable<T>
    {
        private T[] elements;

        public ListT()
        {
            const int initialSize = 4;
            elements = new T[initialSize];
        }

        public int Count { get; set; }

        public virtual T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return elements[i];
            }
        }

        public virtual void Add(T element)
        {
            VerifyNumberOfElements();
            elements[Count] = element;
            Count++;
        }

        public bool Contains(T element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(elements[i], element))
                {
                    return i;
                }
            }

            return -1;
        }

        public virtual void Insert(int index, T element)
        {
            VerifyNumberOfElements();
            Count++;
            ShiftRight(index);

            elements[index] = element;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        public void Clear()
        {
            Array.Resize(ref elements, 0);
            Count = 0;
        }

        public void Remove(T element)
        {
            if (IndexOf(element) == -1)
            {
                return;
            }

            RemoveAt(IndexOf(element));
        }

        public void RemoveAt(int index)
        {
            ShiftLeft(index);
            Count--;
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
