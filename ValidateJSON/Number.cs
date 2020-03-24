namespace ValidateJSON
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            var onenine = new Range('1', '9');
            var zero = new Character('0');
            var digit = new Range('0', '9');
            var digits = new OneOrMore(digit);
            var sign = new Optional(new Any("+-"));
            var natural = new Sequence(onenine, new Many(digit));
            var integer = new Choice(zero, new Sequence(new Optional(new Character('-')), natural));
            var fractional = new Sequence(new Character('.'), digits);
            var exponential = new Sequence(new Any("Ee"), sign, digits);
            pattern = new Sequence(integer, new Optional(fractional), new Optional(exponential));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
