namespace ValidateJSON
{
        public class Value : IPattern
        {
            private readonly IPattern pattern;

            public Value()
            {
            var number = new Number();
            var @string = new String();

            var value = new Choice(
                        @string,
                        number,
                        new Text("true"),
                        new Text("false"),
                        new Text("null"));

            var ws = new Any(" \r\n\t");

            var element = new Sequence(ws, value, ws);
            var elements = new List(element, new Character(','));

            var array = new Choice(
                new Sequence(new Character('['), ws, new Character(']')),
                new Sequence(new Character('['), elements, new Character(']')));

            var member = new Sequence(ws, @string, ws, new Character(':'), element);
            var members = new List(member, new Character(','));

            var @object = new Choice(
                new Sequence(new Character('{'), ws, new Character('}')),
                new Sequence(new Character('{'), members, new Character('}')));

            value.Add(array);
            value.Add(@object);
            pattern = value;
            }

            public IMatch Match(string text)
            {
                return pattern.Match(text);
            }
        }
}
