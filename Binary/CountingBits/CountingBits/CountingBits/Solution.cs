using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingBits
{
    public class Solution
    {
        // T O[nlogn]
        public int[] CountBits(int n)
        {
            int[] res = new int[n+1];

            for (int i = 0; i <= n; i++)
            {
                int ContainOneflag = 0;
                int num = i;
                while(num > 0)
                {
                    ContainOneflag += num % 2;
                    num /= 2;
                }
                res[i] = ContainOneflag;
            }

            return res;
        }
    }
}
