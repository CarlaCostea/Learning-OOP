using System;

namespace ArrayOperations
{
    public class IntArray
    {
        private int[] elements;
        private int count;

        public IntArray()
        {
            const int initialSize = 4;
            this.elements = new int[initialSize];
        }

        public void Add(int element)
        {
            VerifyNumberOfElements();
            elements[count] = element;
            count++;
        }

        public int Count()
        {
            return count;
        }

        public int Element(int index)
        {
            return elements[index];
        }

        public void SetElement(int index, int element)
        {
            elements[index] = element;
        }

        public bool Contains(int element)
        {
            return IndexOf(element) != -1;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < elements.Length; i++)
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
            count++;
        }

        public void Clear()
        {
            Array.Resize(ref elements, 0);
            count = 0;
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
            count--;
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < elements.Length - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = elements.Length - 1; i > index + 1; i--)
            {
                elements[i] = elements[i - 1];
            }
        }

        private void VerifyNumberOfElements()
            {
            const int doubleLength = 2;

            if (count != elements.Length)
            {
                return;
            }

            Array.Resize(ref elements, elements.Length * doubleLength);
        }
    }
}
