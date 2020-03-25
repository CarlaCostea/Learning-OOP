namespace ValidateJSON
{
    public class String : IPattern
    {
        private readonly IPattern pattern;

        public String()
        {
            pattern = new Many(pattern);
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
