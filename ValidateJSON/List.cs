namespace ValidateJSON
{
    public class List : IPattern
    {
        private readonly IPattern pattern;

        public List(IPattern element, IPattern separator)
        {
            this.pattern = new Many(new Sequence(new OneOrMore(element), new Optional(separator), new Sequence(new Many(element), new Optional(separator), new Many(element))));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
