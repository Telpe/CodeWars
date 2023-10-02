using System.Text;

namespace KataSolution
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            var sb = new StringBuilder();

            foreach (var letter in str)
            {
                if (!vowels.Contains(letter))
                {
                    sb.Append(letter);
                }
            }

            return sb.ToString();
        }
    }
}