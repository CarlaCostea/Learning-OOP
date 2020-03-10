namespace ValidateJSON
{
    public interface IMatch
    {
        bool Success();

        string RemainingText();
    }
}