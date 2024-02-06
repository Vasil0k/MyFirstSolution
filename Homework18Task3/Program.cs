using System.Diagnostics;

namespace Homework18Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            List<int> ints = Enumerable.Range(1, 100).ToList();
            Console.WriteLine("Consistently");
            stopwatch.Start();            
            ints.ForEach(Action());
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            stopwatch.Restart();
            stopwatch.Start();
            Console.WriteLine("Parallel");
            Parallel.ForEach(ints, Action());
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
        }

        private static Action<int> Action()
        {
            return i => Console.Write($"{i}^2: {i * i}, ");
        }
    }


}
