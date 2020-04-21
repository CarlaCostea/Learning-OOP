namespace ArrayOperations
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray()
        {
        }

        public override int this[int index]
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

        public override void Add(int element)
        {
            base.Insert(GetPosition(element), element);
        }

        public override void Insert(int index, int element)
        {
            if (GetPosition(element) != index)
            {
                return;
            }

            base.Insert(index, element);
        }

        private int GetPosition(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (element < this[i])
                {
                    return i;
                }
            }

            return Count;
        }
    }
}
