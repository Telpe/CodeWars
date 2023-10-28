using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataSolution
{
    public class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a.Length != b.Length || a.Length == 0) { throw new Exception("a and b must not be empty and must be of the same length"); }
            
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
    }
}
