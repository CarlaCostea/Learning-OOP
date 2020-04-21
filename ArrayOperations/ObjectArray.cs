using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public class ObjectArray
    {
        private object[] elements;

        public ObjectArray()
        {
            const int initialSize = 4;
            elements = new object[initialSize];
        }

        public int Count { get; set; }

        public virtual object this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public virtual void Add(object element)
        {
            VerifyNumberOfElements();
            elements[Count] = element;
            Count++;
        }

        public bool Contains(object element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(object element)
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

        public virtual void Insert(int index, object element)
        {
            VerifyNumberOfElements();
            Count++;
            ShiftRight(index);

            elements[index] = element;
        }

        public void Clear()
        {
            Array.Resize(ref elements, 0);
            Count = 0;
        }

        public void Remove(object element)
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
