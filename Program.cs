using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest_Lab1"), InternalsVisibleTo("Lab1_Forms")]
namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? line = "";
            int seed = 0;
            int n = 0;
            int capacity = 0;

            try
            {
                Console.WriteLine("Enter seed:");
                line = Console.ReadLine();
                seed = Convert.ToInt32(line);
                Console.WriteLine("Enter number of items:");
                line = Console.ReadLine();
                n = Convert.ToInt32(line);
                if (n < 0)
                {
                    Console.WriteLine("Invalid number of items");
                    return;
                }
                Console.WriteLine("Enter capacity:");
                line = Console.ReadLine();
                capacity = Convert.ToInt32(line);
                if (capacity < 0)
                {
                    Console.WriteLine("Invalid capacity");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Problem problem = new Problem(n, seed);

            Console.WriteLine("Our items and their parameters: ");
            Console.WriteLine(problem);

            Console.WriteLine("Solution for capacity " + capacity);
            Console.WriteLine(problem.Solve(capacity));
        }
    }
}
