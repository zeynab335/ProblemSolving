using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumbers
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int DistinctNumbers  = -1;

            Dictionary<int,int> Visited = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++) {
                
                if (Visited.ContainsKey(nums[i]))
                {
                    Visited[nums[i]] = 1;
                }
                else
                {
                    Visited[nums[i]] = 0;
                }
            }
            
            foreach (var value in Visited)
            {
                if (value.Value == 0)
                {
                    DistinctNumbers = value.Key;
                }
            }


            return DistinctNumbers;


        }
    }
}
