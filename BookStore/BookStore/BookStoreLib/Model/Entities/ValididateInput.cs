namespace BookStore.Model.Entities
{
    public static class ValididateInput
    {
        public static bool IsSpaceCharacters(this string input) => input.Any(char.IsWhiteSpace);

        public static bool IsDigit(this string input) => input.All(char.IsDigit);

        public static bool IsNullOrEmpty(this string input) => string.IsNullOrEmpty(input);
    }
}
