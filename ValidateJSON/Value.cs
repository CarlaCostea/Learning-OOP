namespace ValidateJSON
{
        public class Value : IPattern
        {
            private readonly IPattern pattern;

            public Value()
            {
                pattern = new Many(new Number());
            }

            public IMatch Match(string text)
            {
                return pattern.Match(text);
            }
        }
}
