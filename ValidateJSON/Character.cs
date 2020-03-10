using System;

namespace ValidateJSON
{
    public class Character : IPattern
    {
        readonly char pattern;

        public Character(char pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Match(text, false);
            }

            if (text[0] == pattern)
            {
                return new Match(text.Substring(1), true);
            }

            return new Match(text, false);
        }
    }
}
