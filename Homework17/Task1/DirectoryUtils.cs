namespace Homework17.Task1
{
    internal class DirectoryUtils
    {
        public static int GetFileCount(string path)
        {
            return Directory.GetFiles(path).Length;     
        }

        public static int GetFileCount(string path, string extension)
        {
            return new DirectoryInfo(path).GetFiles().Where(f => f.Extension.Equals(extension)).Count();
        }

        public static FileInfo[] GetFiles(string path)
        {
            return new DirectoryInfo(path).GetFiles();
        }

        public static FileInfo[] GetFiles(string path, string extension)
        {
            return new DirectoryInfo(path).GetFiles().Where(f => f.Extension.Equals(extension)).ToArray();
        }
    }
}
