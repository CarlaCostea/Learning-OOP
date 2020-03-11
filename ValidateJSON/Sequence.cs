namespace ValidateJSON
{
    public class Sequence : IPattern
    {
        private readonly IPattern[] patterns;

        public Sequence(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            string initialText = text;
            foreach (var pattern in patterns)
            {
                var match = pattern.Match(text);
                if (!match.Success())
                {
                    return new Match(initialText, false);
                }

                text = match.RemainingText();
            }

            return new Match(text, true);
        }
    }
}
