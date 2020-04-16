namespace ArrayOperations
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray()
        {
        }

        public override void Add(int element)
        {
            if (Count == 0)
            {
                base.Add(element);
            }

            if (Count == 1 && this[0] > element)
            {
                Insert(0, element);
            }

            if (Count == 1 && this[0] < element)
            {
                base.Add(element);
            }

            for (int i = 2; i < Count; i++)
            {
                if (this[i] > element)
                {
                    Insert(i, element);
                }

                if (this[i] < element && element < this[i + 1])
                {
                    Insert(i + 1, element);
                }

                base.Add(element);
            }
        }
    }
}
