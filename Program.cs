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

            Console.WriteLine("Enter seed:");
            try
            {
                line = Console.ReadLine();
                seed = Convert.ToInt32(line);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid seed");
                return;
            }

            Console.WriteLine("Enter number of items:");
            try
            {
                line = Console.ReadLine();
                n = Convert.ToInt32(line);
                if (n < 0)
                {
                    Console.WriteLine("Invalid number of items");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number of items");
                return;
            }

            Problem problem = new Problem(n, seed);

            Console.WriteLine("Our items and their parameters: ");
            Console.WriteLine(problem);

            Console.WriteLine("Enter capacity:");
            try
            {
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
                Console.WriteLine("Invalid capacity");
                return;
            }

            Console.WriteLine("For capacity " + capacity + " we can take:");
            Console.WriteLine(problem.Solve(capacity));
        }
    }
}
