using System;
using System.Collections;

namespace KataSolution
{
    public class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            // if not the same length, there is no need to waste anymore time.
            if (null == a || null == b || a.Length != b.Length) { return false; }
            //if(a.Length == 0) { return false; }

            List<int> bList = b.ToList();

            for (int i = 0; i < a.Length; i++) 
            {
                int bPos = bList.IndexOf(a[i] * a[i]);
                if (-1 < bPos) 
                { 
                    bList.RemoveAt(bPos);
                }
                else
                {
                    return false;
                }
            }
            
            return true;
        }

        public static bool compSame(int[] a, int[] b)
        {
            // should not pass positive tests if given negative numbers.
            if (null == a || null == b || a.Length != b.Length || b.Length == 0) { return false; }

            List<int> aList = a.ToList();

            for (int i = 0; i < b.Length; i++)
            {
                int aPos = aList.IndexOf((int)Math.Sqrt(b[i]));
                if (-1 < aPos)
                {
                    aList.RemoveAt(aPos);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
