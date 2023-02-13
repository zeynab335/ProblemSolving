using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            long MaxFirst = long.MinValue, MaxSecond = long.MinValue, MaxThird = long.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {

                if (MaxFirst < nums[i])
                {
                    MaxThird = MaxSecond;
                    MaxSecond = MaxFirst;
                    MaxFirst = nums[i];
                }
                else if (nums[i] < MaxFirst && MaxSecond < nums[i])
                {
                    MaxThird = MaxSecond;
                    MaxSecond = nums[i];
                }
                else if (nums[i] > MaxThird && nums[i] != MaxFirst && nums[i] != MaxSecond)
                {
                    MaxThird = nums[i];
                }

            }
            return (int)(MaxThird == long.MinValue ? MaxFirst : MaxThird);    
        }
    }

}
