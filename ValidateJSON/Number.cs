namespace ValidateJSON
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            var onenine = new Range('1', '9');
            var zero = new Character('0');
            var digits = new Choice(zero, onenine);
            var natural = new Sequence(onenine, new Many(digits));
            var integer = new Sequence(new Optional(new Character('-')), natural);
            var fractional = new Sequence(new Character('.'), natural);
            this.pattern = new Sequence(new Choice(integer, zero), new Optional(fractional));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
