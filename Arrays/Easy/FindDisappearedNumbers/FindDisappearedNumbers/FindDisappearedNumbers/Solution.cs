using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDisappearedNumbers
{
    public class Solution
    {
        // return an array of all the integers in the range [1, n]
        // that do not appear in nums.
        public IList<int> FindDisappearedNumbersV1(int[] nums)
        {
            List<int> lst = new List<int>();

            for (int num = 1; num<nums.Length+1; num++  )
            {
                lst.Add(num);
            }

            for (int num = 0; num < nums.Length; num++)
            {
                if (lst.Contains(nums[num]))

                {
                    lst.Remove(nums[num]);
                }
            }
           


            return lst;
        }



        //  Version 2
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> lst = new List<int>();

            Dictionary<int, int> Visited = new Dictionary<int, int>();
            // initialize list 
            for (int i= 0; i<= nums.Length ; i++ )
            {
                Visited[i] = 0; 
            }

            for (int num = 0; num < nums.Length; num++)
            {
                Visited[nums[num]] = 1;
            }

            for (int num = 1; num <= nums.Length; num++)
            {
                if (Visited[num] != 1)
                {
                    lst.Add(num);
                }
            }


            return lst;
        }
    }
}
