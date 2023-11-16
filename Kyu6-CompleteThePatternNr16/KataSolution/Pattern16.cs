using System;
using System.Collections;

namespace KataSolution
{
    public class Pattern16
    {
        public static string Pattern(int n)
        {
            if (1 > n) { return ""; }

            char[] line = new char[n];
            string[] lines = new string[n];

            for (int i = 0; n > 0; n--, i++)
            {
                line[i] = n.ToString()[^1];

                for (int iNext = i+1; iNext < line.Length; iNext++)
                {
                    line[iNext] = line[i];
                }

                lines[i] = new string(line);
            }

            // consider replacing '\n' with Environment.NewLine
            return string.Join('\n', lines); 
        }
    }
}