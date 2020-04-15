namespace ArrayOperations
{
    public class SortedIntArray : IntArray
    {
        public int[] SortedElements;

        public SortedIntArray()
        {
            QuickSort(Elements, 0, Count);
            this.SortedElements = Elements;
        }

        private void QuickSort(int[] elements, int start, int end)
        {
            int i;
            if (start >= end)
            {
                return;
            }

            i = Partition(elements, start, end);

            QuickSort(elements, start, i - 1);
            QuickSort(elements, i + 1, end);
        }

        private int Partition(int[] elements, int start, int end)
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
