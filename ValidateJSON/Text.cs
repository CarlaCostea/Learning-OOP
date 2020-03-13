namespace ValidateJSON
{
    public class Text : IPattern
    {
        private readonly string prefix;

        public Text(string prefix)
        {
            this.prefix = prefix;
        }

        public IMatch Match(string text)
        {
            return string.IsNullOrEmpty(text) || !text.StartsWith(prefix)
                ? new Match(text, false)
                : new Match(text.Substring(prefix.Length), true);
        }
    }
}
