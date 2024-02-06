namespace Homework18Task5
{
    internal class Program
    {
        static readonly object lock1 = new();
        static readonly object lock2 = new();

        static void Main(string[] args)
        {
            var thread1 = new Thread(() =>
            {
                AcquireLocks(lock1, lock2);
            });
            var thread2 = new Thread(() =>
            {
                AcquireLocks(lock1, lock2);
            });

            thread1.Name = "Thread 1";
            thread2.Name = "Thread 2";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Finished.");
            Console.ReadLine();
        }

        private static void AcquireLocks(object firstLock, object secondLock)
        {
            var threadId = Environment.CurrentManagedThreadId;

            lock (firstLock)
            {
                Console.WriteLine($"Thread {threadId} acquired lock 1.");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread {threadId} attempted to acquire lock 2.");
                lock (secondLock)
                {
                    Console.WriteLine($"Thread {threadId} acquired lock 2.");
                }
            }
        }       
    }
}
