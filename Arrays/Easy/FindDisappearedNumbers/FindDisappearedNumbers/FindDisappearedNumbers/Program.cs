namespace FindDisappearedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var lst = s.FindDisappearedNumbers(new int[] {1,1 });
            foreach (int num in lst)
            {
                Console.WriteLine(num);
            }
        }
    }
}