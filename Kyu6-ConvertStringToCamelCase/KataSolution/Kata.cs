using System;
using System.Diagnostics;

namespace KataSolution
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            string[] pre = str.Split(new char[] { '-', '_', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (0 == pre.Length){ return ""; }

            string result = pre[0];
            
            for (int i = 1; i < pre.Length; i++)
            {
                result += pre[i].Substring(0,1).ToUpperInvariant();
                result += pre[i].Substring(1);
            }
            
            return result;
        }
    }
}