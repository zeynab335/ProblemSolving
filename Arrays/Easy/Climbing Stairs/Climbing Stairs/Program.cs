namespace Climbing_Stairs
{
    internal class Program
    {
        public static int OptimizeFib(int n, int first, int second)
        {
            if (n == 0) return first;
            if (n == 1) return second;
            return OptimizeFib(n - 1, second , first + second);
        }

        public static int Fib(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            return Fib(num - 1) + Fib(num-2);


        }

        public static int Fun (int num)
        {
            int first = 1 ; int second = 1 , temp = 0;
            for(var i=1 ; i< num; i++)
            {
                temp = second;
                second += first ;
                first = temp ;
            }
            return second;
        }

        public static void ClimbStairs(int num)
        {
            //Console.WriteLine(Fib(num));
            //Console.WriteLine(Fun(num));
            Console.WriteLine(OptimizeFib(num,1,1));
        }
        static void Main(string[] args)
        {
            ClimbStairs(5) ;
        }
    }
}