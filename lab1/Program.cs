using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Test")]
[assembly: InternalsVisibleTo("gui")]


namespace lab1
{
    internal class Display
    {

        static void Main(string[] args)
        {
            Problem problem = new Problem(5,2);
            Result result = problem.Solve(18);
            Console.WriteLine(problem);
            Console.WriteLine(result.ToString());

        }

    }
}
