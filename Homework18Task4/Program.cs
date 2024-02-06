namespace Homework18Task4
{
    internal class Program
    {
        private static readonly object lockObject = new();
        static void Main(string[] args)
        {
            string file1 = @"c:\test\file1.txt";
            string file2 = @"c:\test\file2.txt";
            string file3 = @"c:\test\file3.txt";

            File.WriteAllText(file1, $"File 1 Content{Environment.NewLine}");
            File.WriteAllText(file2, $"File 2 Content{Environment.NewLine}");
            File.WriteAllText(file3, "");

            Thread thread1 = new(t => CopyContentToFile(file1, file3));
            Thread thread2 = new(t => CopyContentToFile(file2, file3));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine($"content after writing to {file3}:{Environment.NewLine}{File.ReadAllText(file3)}");
        }

        static void CopyContentToFile(string source, string target) 
        {
            string content = File.ReadAllText(source);

            lock(lockObject)
            {
                File.AppendAllText(target, content);
            }                    
        }
    }
}
