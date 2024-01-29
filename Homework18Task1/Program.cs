namespace Homework18Task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Task 1
            Thread thread1 = new Thread(() =>
            {
                char[] chars = Enumerable.Range('a', 'z' - 'a' + 1).Select(ch => (char) ch).ToArray();
                foreach (char ch in chars)
                {
                    Console.WriteLine(ch);
                    Thread.Sleep(100);
                }
            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 26; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            });
            thread1.Start();
            thread2.Start();
        }
    }
}
