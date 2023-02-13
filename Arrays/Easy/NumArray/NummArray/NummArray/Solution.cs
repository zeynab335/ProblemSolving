using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummArray
{
    public class NumArray
    {
        private int[] nums = null;
        public NumArray(int[] nums)
        {
            #region First Implementation  [Brute force]
            /*
            this.nums = new int[nums.Length];
            for (int i=0; i<nums.Length; i++)
            {
                this.nums[i] = nums[i];
            }
            */

            #endregion


            #region Second Implementation 

            this.nums = new int[nums.Length];
            this.nums[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                this.nums[i] = this.nums[i-1] + nums[i];
            }
            #endregion

        }

        public int SumRange(int left, int right)
        {
            #region First Implementation 
            int sum = 0;
            //for (int i = left; i <= right; i++)
            //{
            //    sum += this.nums[i];
            //return sum;
            //}
            #endregion

            #region Second Implementation 
            if (left < 0 || right > nums.Length)
            {
                return 0;
            }
            else if (left == 0) return this.nums[right];

            return this.nums[right] - this.nums[left-1];


            #endregion
        }
    }
}
