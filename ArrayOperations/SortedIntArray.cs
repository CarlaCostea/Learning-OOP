namespace ArrayOperations
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray()
        {
            QuickSort(ref Elements, 0, Count);
        }

        private void QuickSort(ref int[] elements, int start, int end)
        {
            int i;
            if (start >= end)
            {
                return;
            }

            i = Partition(ref elements, start, end);

            QuickSort(ref elements, start, i - 1);
            QuickSort(ref elements, i + 1, end);
        }

        private int Partition(ref int[] elements, int start, int end)
        {
            int temp;
            double p = elements[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (elements[j] > p)
                {
                    i++;
                    temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;
                }
            }

            temp = elements[i + 1];
            elements[i + 1] = elements[end];
            elements[end] = temp;
            return i + 1;
        }
    }
}
