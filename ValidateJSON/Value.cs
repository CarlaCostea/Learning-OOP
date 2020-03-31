namespace ValidateJSON
{
        public class Value : IPattern
        {
            private readonly IPattern pattern;

            public Value()
            {
            var number = new Number();
            var @string = new String();
            var ws = new Choice(new Character('\u0020'), new Character('\u000A'), new Character('\u000D'), new Character('\u0009'));
            var value = new Value();
            var element = new List(value, ws);
            var elements = new Choice(element, new Sequence(element, new Character(','), new OneOrMore(element)));
            pattern = new Choice(
                        @string,
                        number,
                        new Text("true"),
                        new Text("false"),
                        new Text("null"));
            }

            public IMatch Match(string text)
            {
                return pattern.Match(text);
            }
        }
}
