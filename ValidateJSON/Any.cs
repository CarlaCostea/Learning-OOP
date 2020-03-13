namespace ValidateJSON
{
    public class Any : IPattern
    {
        private readonly string accepted;

        public Any(string accepted)
        {
            this.accepted = accepted;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Match(text, false);
            }

            for (int i = 0; i < accepted.Length; i++)
            {
                if (text[0] == accepted[i])
                {
                    return new Match(text.Substring(1), true);
                }
            }

            return new Match(text, false);
        }
    }
}
