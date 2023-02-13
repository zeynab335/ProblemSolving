using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    public class Solution
    {
        //public bool ContainsDuplicate(int[] nums)
        //{
        //    int flag = 0; // no dublicates;
        //    int F = 0;
        //    int L = 1;


        //    while(F < nums.Length && flag != 1) 
        //    {

        //        if (L >= nums.Length )
        //        {
        //            L = ++F + 1; 
        //        }
        //        else
        //        {
        //            if (nums[F] == nums[L])
        //            {
        //                flag = 1;
        //                break;
        //            }
        //            else {
        //                L++;
        //            }
        //        }

        //    }


        //    return flag == 1 ? true : false;
        //}

        /// Time Complextiy => O(n*logn)  
        /// Space Complextiy => O(1)  [don't create any variables ]


        public bool ContainsDuplicate1(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (nums[i] == nums[i + 1])
                    return true;
            }
            return false;
        }

        public bool ContainsDuplicate2(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) return true;
                else
                {
                    set.Add(nums[i]);
                }
            }
            return false;
        }
    }
}


