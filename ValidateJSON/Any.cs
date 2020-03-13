namespace ValidateJSON
{
    public class Any : IPattern
    {
        private readonly string accepted;

        public Any(string accepted)
        {
            this.accepted = accepted;
        }

        public IMatch Match(string text)
        {
            return string.IsNullOrEmpty(text) || !accepted.Contains(text[0])
                ? new Match(text, false)
                : new Match(text.Substring(1), true);
        }
    }
}
