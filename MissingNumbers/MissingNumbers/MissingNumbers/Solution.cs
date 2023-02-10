using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{
    public class Solution
    {
        #region First Implementatio [but it take more memory O(n) && time o(2n)]
        public int MissingNumberV1(int[] nums)
        {

            // create hashset to store all Range numbers

            HashSet<int> result = new HashSet<int>();

            for (int j = 0; j < nums.Length + 1; j++)
            {
                result.Add(j);
            }

            int i = 0;
            Array.Sort(nums);

            while (i < result.Count())
            {
                if (i < nums.Length)
                {
                    if (result.ElementAt(nums[i]) != i) return i;

                    i++;
                }
                else { return i; }
            }




            return 0;

        }
        #endregion


        // Second Implementation 
        // will take memory => O(n) and Time O(n)
        public int MissingNumberV2(int[] nums)
        {

            return Enumerable.Range(0, nums.Length + 1).Sum() - nums.Sum();

        }

        // Another version to sum

        public int MissingNumberV3(int[] nums)
        {
            var Range = Enumerable.Range(0, nums.Length + 1);

            // sum[0,1,2]  - sum[1,2,3]  => [0-1] + [1-2] + [2-3]

            int result = 0;
            for (int i = 0; i < Range.Count(); i++)
            {
                try
                {
                    result += i - nums[i];
                }
                catch { result += i - 0; }
            }
            return result;
        }



        // using Exclusive Operator [only retun 1 if two numbers are differents]
        //  1 ^ 1 ==> 01 ^ 01 ==> 0
        // Almost it is the best solution
        public int MissingNumber(int[] nums)
        {
            int xor = nums.Length; // to get the last value of Range

            // [1,2,0]
            for (int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
                xor ^= i;
            }
            return xor;
        }
    }
}
