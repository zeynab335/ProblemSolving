namespace SingleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution solution = new Solution();
            Console.WriteLine( solution.SingleNumber(new int[] { 2, 2, 1 }));
        }
    }
}