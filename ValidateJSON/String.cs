namespace ValidateJSON
{
    public class String : IPattern
    {
        private readonly IPattern pattern;

        public String()
        {
            var hex = new Choice(new Range('0', '9'), new Range('A', 'F'), new Range('a', 'f'));
            var character = new Choice(new Any(" !"), new Range('#', '['), new Range(']', '\uFFFF'));
            var quotes = new Character('"');
            var escapeChar = new Character('\\');
            var controlChar = new Sequence(escapeChar, new Any("abtnvfr\\\"/"));
            var unicode = new Sequence(escapeChar, new Character('u'), hex, hex, hex, hex);
            pattern = new Sequence(quotes, new Many(new Choice(character, controlChar, unicode)), quotes);
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
