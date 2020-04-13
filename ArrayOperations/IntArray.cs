using System;

namespace ArrayOperations
{
    public class IntArray
    {
        private int[] elements;

        public IntArray()
        {
            this.elements = new int[] { };
        }

        public void Add(int element)
        {
            Array.Resize(ref elements, elements.Length + 1);
            elements[^1] = element;
        }

        public int Count()
        {
            return elements.Length;
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
            ShiftRight(index);

            elements[index] = element;
        }

        public void ShiftRight(int index)
        {
            Array.Resize(ref elements, elements.Length + 1);
            for (int i = elements.Length - 1; i > index + 1; i--)
            {
                elements[i] = elements[i - 1];
            }
        }

        public void Clear()
        {
            Array.Resize(ref elements, 0);
        }

        public void Remove(int element)
        {
            // șterge prima apariție a elementului din șir
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == element)
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < elements.Length - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            Array.Resize(ref elements, elements.Length - 1);
        }
    }
}
