using System;

namespace ArrayOperations
{
    public class IntArray
    {
        public int[] Elements;

        public IntArray()
        {
            const int initialSize = 4;
            Elements = new int[initialSize];
        }

        public int Count { get; set; }

        public int this[int index]
        {
            get => Elements[index];
            set => Elements[index] = value;
        }

        public virtual void Add(int element)
        {
            VerifyNumberOfElements();
            Elements[Count] = element;
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
                if (Elements[i] == element)
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

            Elements[index] = element;
            Count++;
        }

        public void Clear()
        {
            Array.Resize(ref Elements, 0);
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

            if (Count != Elements.Length)
            {
                return;
            }

            Array.Resize(ref Elements, Elements.Length * doubleLength);
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                Elements[i] = Elements[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i > index + 1; i--)
            {
                Elements[i] = Elements[i - 1];
            }
        }
    }
}
