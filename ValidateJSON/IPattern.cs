namespace ValidateJSON
{
    public interface IPattern
    {
        IMatch Match(string text);
    }
}
