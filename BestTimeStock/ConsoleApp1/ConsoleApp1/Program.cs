namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MaxProfit(new int[] {1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9}));
        }
    }
}