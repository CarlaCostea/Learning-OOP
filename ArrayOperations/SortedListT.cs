using System;

namespace ArrayOperations
{
    public class SortedListT<T> : ListT<T>
        where T : IComparable<T>
    {
        public SortedListT()
        {
        }

        public override T this[int index]
        {
            get => base[index];

            set
            {
                if (GetPosition(value) != index)
                {
                    return;
                }

                base[index] = value;
            }
        }

        public override void Add(T element)
        {
            base.Insert(GetPosition(element), element);
        }

        public override void Insert(int index, T element)
        {
            if (GetPosition(element) != index)
            {
                return;
            }

            base.Insert(index, element);
        }

        private int GetPosition(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (element.CompareTo(this[i]) < 0)
                {
                    return i;
                }
            }

            return Count;
        }
    }
}
