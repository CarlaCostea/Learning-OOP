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
            // adaugă un nou element pe poziția dată
            Array.Resize(ref elements, elements.Length + 1);
            for (int i = elements.Length - 1; i > index + 1; i--)
            {
                elements[i] = elements[i - 1];
            }

            elements[index] = element;
        }

        public void Clear()
        {
            // șterge toate elementele din șir
            Array.Resize(ref elements, 0);
        }

        public void Remove(int element)
        {
            // șterge prima apariție a elementului din șir
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == element)
                {
                    for (int j = i; j < elements.Length - 1; j++)
                    {
                        elements[j] = elements[j + 1];
                    }

                    break;
                }
            }

            Array.Resize(ref elements, elements.Length - 1);
        }

        public void RemoveAt(int index)
        {
            // șterge elementul de pe poziția dată
            for (int i = index; i < elements.Length - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            Array.Resize(ref elements, elements.Length - 1);
        }
    }
}
