namespace ValidateJSON
{
    public class OneOrMore : IPattern
    {
        private readonly IPattern pattern;

        public OneOrMore(IPattern pattern)
        {
            this.pattern = new Many(pattern);
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
