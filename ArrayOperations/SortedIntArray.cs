namespace ArrayOperations
{
    public class SortedIntArray : IntArray
    {
        public SortedIntArray()
        {
        }

        public override int this[int index]
        {
            get => this[index];
            set
                {
                if (index == 0 && value <= this[0])
                {
                    this[index] = value;
                    return;
                }

                if (index == Count - 1 && value >= this[Count - 1])
                {
                    this[index] = value;
                    return;
                }

                if (index <= 0 || index >= Count - 1 || this[index] < value)
                {
                    return;
                }

                this[index] = value;
            }
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
                    base.Insert(i, element);
                    return;
                }

                if (this[i] < element && element < this[i + 1])
                {
                    base.Insert(i + 1, element);
                    return;
                }

                if (element > this[Count - 1])
                {
                    base.Insert(Count, element);
                    return;
                }
            }
        }

        public override void Insert(int index, int element)
            {
            if (index == 0 && element <= this[0])
            {
                base.Insert(index, element);
                return;
            }

            if (index == Count - 1 && element >= this[Count - 1])
            {
                base.Insert(index, element);
                return;
            }

            if (index <= 0 || index >= Count - 1 || this[index] < element)
            {
                return;
            }

            base.Insert(index, element);
        }
    }
}
