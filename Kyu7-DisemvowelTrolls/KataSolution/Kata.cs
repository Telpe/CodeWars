using System.Text;

namespace KataSolution
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            var sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str.ElementAt(i)))
                {
                    sb.Append(str.ElementAt(i));
                }
            }
            
            return sb.ToString();
        }
    }
}