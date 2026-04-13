public static class InputHandler
{
    public static bool IsInvalid(string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }
}