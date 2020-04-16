using System;

namespace ArrayOperations
{
    public class IntArray
    {
        private int[] elements;

        public IntArray()
        {
            const int initialSize = 4;
            elements = new int[initialSize];
        }

        public int Count { get; set; }

        public int this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public virtual void Add(int element)
        {
            VerifyNumberOfElements();
            elements[Count] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, int element)
        {
            VerifyNumberOfElements();
            ShiftRight(index);

            elements[index] = element;
            Count++;
        }

        public void Clear()
        {
            Array.Resize(ref elements, 0);
            Count = 0;
        }

        public void Remove(int element)
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

        public void VerifyNumberOfElements()
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
            for (int i = Count - 1; i > index + 1; i--)
            {
                elements[i] = elements[i - 1];
            }
        }
    }
}
