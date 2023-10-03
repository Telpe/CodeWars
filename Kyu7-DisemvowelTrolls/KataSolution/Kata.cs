using System.Text;

namespace KataSolution
{
    public static class Kata
    {
        public static char[] Vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        public static string Disemvowel(string str)
        {
            var sb = new StringBuilder();

            foreach (var letter in str)
            {
                if (-1 == Array.IndexOf(Vowels, letter))
                {
                    sb.Append(letter);
                }
            }

            return sb.ToString();
        }

        public static string Disemvowel2(string str)
        {
            string[] parts = str.Split(Vowels);

            return String.Concat(parts);
        }
    }
}