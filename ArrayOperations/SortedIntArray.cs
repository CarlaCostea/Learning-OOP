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
                this[0] = element;
                Count++;
            }

            for (int i = 0; i < Count; i++)
            {
                if (this[i] > element)
                {
                    Insert(i, element);
                    return;
                }

                if (this[i] < element && element < this[i + 1])
                {
                    Insert(i + 1, element);
                    return;
                }

                if (element > this[Count - 1])
                {
                    Count++;
                    this[Count - 1] = element;
                }
            }
        }
    }
}
