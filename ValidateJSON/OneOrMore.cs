namespace ValidateJSON
{
    public class OneOrMore : IPattern
    {
        private readonly IPattern pattern;

        public OneOrMore(IPattern pattern)
        {
            // aici folosește-te de clasele implementate deja
            // pentru a construi un pattern care să îl folosești în Match
            this.pattern = new Many(pattern);
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
