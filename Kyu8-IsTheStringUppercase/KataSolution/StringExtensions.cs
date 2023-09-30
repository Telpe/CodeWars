namespace KataSolution
{
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            // Create a method to see whether the string is ALL CAPS.

            return text.ToUpper() == text;
        }
    }

    
}