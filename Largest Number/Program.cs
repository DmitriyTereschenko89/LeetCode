namespace Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            Console.WriteLine(solution.LargestNumber([10, 2]));
            Console.WriteLine(solution.LargestNumber([3, 30, 34, 5, 9]));
        }
    }
}
