using Homework17.Task1;
using Homework17.Task4;
using Newtonsoft.Json;
using System.Text;

namespace Homework17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string path = @"c:\test";
            Console.Write("Number of files: ");
            Console.WriteLine(DirectoryUtils.GetFileCount(path));
            Console.Write("Number of files with .txt: ");
            Console.WriteLine(DirectoryUtils.GetFileCount(path, ".txt"));
            Console.WriteLine("All files: ");
            foreach (var item in DirectoryUtils.GetFiles(path))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Files with .txt: ");
            foreach (var item in DirectoryUtils.GetFiles(path, ".txt"))
            {
                Console.WriteLine(item);
            }

            //Task 2
            string rootDir = @"c:\test";
            //create dirs
            for (int i = 0; i < 20; i++)
            {
                string p = Path.Combine(rootDir, $"MyTestFolder{i}");
                Directory.CreateDirectory(p);
            }
            Console.WriteLine("check that directories are created");
            Console.ReadKey();
            //delete dirs
            for (int i = 0; i < 20; i++)
            {
                string p = Path.Combine(rootDir, $"MyTestFolder{i}");
                Directory.Delete(p);
            }

            //Task 3
            string fileName = @"c:\test\test.txt";
            using (StreamWriter writer = File.CreateText(fileName))
            {
                writer.WriteLine("Hello from the first row");
                writer.WriteLine("");
                writer.WriteLine("Hello from the third row");
            }
            Console.WriteLine(File.ReadAllText(fileName));

            //Task 4
            MyItem myItem = new MyItem(18, "Mike");
            string jsonItem = JsonConvert.SerializeObject(myItem);
            Console.WriteLine(jsonItem);

            //Task 5
            string file5Name = @"c:\test\test5.txt";
            string text = "HI, my name is tist file";
            string findWhat = "tist";
            string replaceWith = "test";

            File.WriteAllText(file5Name, text);
            string content = File.ReadAllText(file5Name);
            Console.WriteLine($"Initial content: {Environment.NewLine}{content}");
            int idx = content.IndexOf(findWhat);
            
            using (Stream stream = new FileStream(file5Name, FileMode.Open))
            {
                stream.Seek(idx, SeekOrigin.Begin);
                stream.Write(Encoding.ASCII.GetBytes(replaceWith), 1, replaceWith.Length);
            }

            content = File.ReadAllText(file5Name);
            Console.WriteLine($"Changed content: {Environment.NewLine}{content}");

        }
    }
}
