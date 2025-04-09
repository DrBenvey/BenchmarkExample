namespace MyLib
{
    public static class StringExtensions
    {
        public static bool IsIndexOdIsZero(this string input, string search)
        {
            return input.IndexOf(search) == 0;
        }

        public static bool IsStartsWith(this string input, string search)
        {
            return input.StartsWith(search);
        }
    }
}
