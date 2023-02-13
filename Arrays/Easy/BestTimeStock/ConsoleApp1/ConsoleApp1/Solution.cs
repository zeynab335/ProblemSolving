using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int L = 0, R = 1, distance = 0;
            while(R < prices.Length)
            {

                if (prices[L] >= prices[R])
                {
                    Console.WriteLine("dd");
                    L = R;
                }
                else 
                {
                    if(distance < (prices[R] - prices[L]))
                    {
                        distance = prices[R] - prices[L];
                    }
                }
                R++;
            }
            Console.WriteLine(L + " " + R);
            

            return distance ;
        }
    }
}
