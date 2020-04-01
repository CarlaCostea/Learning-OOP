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

            var ws = new Many(new Any(" \r\n\t"));

            var element = new Sequence(ws, value, ws);
            var elements = new List(element, new Character(','));

            var array = new Sequence(ws, new Character('['), ws, elements, ws, new Character(']'), ws);

            var member = new Sequence(ws, @string, ws, new Character(':'), element);
            var members = new List(member, new Character(','));

            var @object = new Sequence(ws, new Character('{'), ws, members, ws, new Character('}'), ws);

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
