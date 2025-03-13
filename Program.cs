using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest_Lab1")]
namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            int seed = (int)dateTime.TimeOfDay.TotalMilliseconds;

            Problem problem = new Problem(10, 0);

            Console.WriteLine("Our items and their parameters: ");
            Console.WriteLine(problem);

            int capacity = 40;

            Console.WriteLine("For capacity " + capacity + " we can take:");
            Console.WriteLine(problem.Solve(capacity));
        }
    }
}
