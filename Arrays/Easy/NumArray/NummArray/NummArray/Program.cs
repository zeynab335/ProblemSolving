namespace NummArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumArray n = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
            Console.WriteLine(n.SumRange(2,5));
        }

    }
}