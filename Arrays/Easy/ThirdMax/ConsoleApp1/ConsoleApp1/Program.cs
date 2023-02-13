namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Console.WriteLine(s.ThirdMax(new int[]{ 5, 4, 6, 0, 8, 10, 7 }));
            Console.WriteLine(s.ThirdMax(new int[] {1, 2, -2147483648}));
            //Console.WriteLine(s.ThirdMax(new int[] { 1,2}));




        }
    }
}