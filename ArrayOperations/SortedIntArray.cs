namespace ArrayOperations
{
    public class SortedIntArray : IntArray
    {
        public int[] SortedElements;

        public SortedIntArray()
        {
            const int initialSize = 4;
            SortedElements = new int[initialSize];
        }

        public override void Add(int element)
        {
            if (Count == 0)
            {
                SortedElements[Count] = element;
            }

            if (Count == 1 && SortedElements[0] > element)
            {
                Insert(0, element);
            }

            if (Count == 1 && SortedElements[0] < element)
            {
                base.Add(element);
            }

            for (int i = 2; i < Count; i++)
            {
                if (SortedElements[i] > element)
                {
                    Insert(i, element);
                    return;
                }

                if (SortedElements[i] < element && element < SortedElements[i + 1])
                {
                    Insert(i + 1, element);
                    return;
                }

                base.Add(element);
            }
        }
    }
}
