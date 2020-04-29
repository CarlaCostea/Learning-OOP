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

        public override void Add(T item)
        {
            base.Insert(GetPosition(item), item);
        }

        public override void Insert(int index, T item)
        {
            if (GetPosition(item) != index)
            {
                return;
            }

            base.Insert(index, item);
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
