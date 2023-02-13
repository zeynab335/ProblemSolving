namespace CountingBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s1 = new Solution();
            var arr = s1.CountBits(5);

            foreach ( var i in arr )
            {
                Console.WriteLine(i);
            }

        }
    }
}