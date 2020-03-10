using System;

namespace ValidateJSON
{
    public class Range : IPattern
    {
        private readonly char start;
        private readonly char end;

        public Range(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Match(text, false);
            }

            if (start <= text[0] && text[0] <= end)
            {
                return new Match(text.Substring(1), true);
            }

            return new Match(text, false);
        }
    }
}
