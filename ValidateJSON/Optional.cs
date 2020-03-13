namespace ValidateJSON
{
    public class Optional : IPattern
    {
        private readonly IPattern pattern;

        public Optional(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            var match = pattern.Match(text);
            if (match.Success())
            {
                return pattern.Match(text);
            }

            return new Match(text, true);
        }
    }
}
