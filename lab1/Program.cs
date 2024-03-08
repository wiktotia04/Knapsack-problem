namespace lab1
{
    internal class Display
    {

        static void Main(string[] args)
        {
            Problem problem = new Problem(2);
            Result result = problem.Solve(10);
            Console.WriteLine(problem);
            Console.WriteLine(result.ToString());

        }

    }
}
