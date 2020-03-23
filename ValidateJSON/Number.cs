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
            var natural = new Sequence(onenine, digits);
            var integer = new Many(new Sequence(new Optional(new Character('-')), natural));
            var fractional = new Sequence(new Character('.'), natural);
            var exponential = new Many(new Sequence(new Any("Ee"), new Optional(new Many(natural)), new Optional(new Any("+-")), new Many(digits)));
            pattern = new Many(new Sequence(integer, new Optional(fractional), new Optional(exponential)));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
