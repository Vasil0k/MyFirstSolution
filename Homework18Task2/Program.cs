namespace Homework18Task2
{
    internal class Program
    {
        private static int counter = 0;
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            List<Thread> threads =  Enumerable.Range(1, 100).Select(i => new Thread(Action) { Name = i.ToString()}).ToList();
            threads.ForEach(t => t.Start());
            threads.ForEach(t => t.Join());
            Console.WriteLine("Joined");
            Console.WriteLine("Expected: 2000000");
            Console.WriteLine($"Actual: {counter}");
        }

        static void Action()
        {
            for (int i = 0; i < 20000; i++)
            {
                mutex.WaitOne();
                counter++;                
                mutex.ReleaseMutex();
            }
        }
    }
}
