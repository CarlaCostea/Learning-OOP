using System;

namespace ArrayOperations
{
    public class IntArray
    {
        private readonly int count;
        private int[] elements;

        public IntArray()
        {
            // construiește noul șir
            this.elements = new int[count];
            this.count = elements.Length;
        }

        public void Add(int element)
        {
            // adaugă un nou element la sfârșitul șirului
            Array.Resize(ref elements, elements.Length + 1);
            elements[^1] = element;
        }

        public int Count()
        {
            // întoarce numărul de elemente din șir
            return count;
        }

        public int Element(int index)
        {
            // întoarce elementul de la indexul dat
            return elements[index];
        }

        public void SetElement(int index, int element)
        {
            // modifică valoarea elementului de la indexul dat
            elements[index] = element;
        }

        public bool Contains(int element)
        {
            // întoarce true dacă elementul dat există în șir
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(int element)
        {
            // întoarce indexul elementului sau -1 dacă elementul nu se regăsește în șir
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
                    for (int j = i; j < elements.Length; j++)
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
            for (int i = index; i < elements.Length; i++)
            {
                elements[i] = elements[i + 1];
            }

            Array.Resize(ref elements, elements.Length - 1);
        }
    }
}
