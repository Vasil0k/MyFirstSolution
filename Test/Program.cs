using Homework7;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HW 7 task 1
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] invertedArray = ArrayWorker.InvertArray(array);
            invertedArray.ToList().ForEach(i => Console.WriteLine(i));

            //hw 7 task 2
            double height = 3;
            double radius = 5;
            Cone cone = new Cone(radius, height);
            Console.WriteLine(cone.GetFullSurfaceArea());
            Console.WriteLine(cone.GetBaseSurfaceArea());

            //hw 7 task 4
            int[] source = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArray(source);
            Homework7.Queue<int> queue = new Homework7.Queue<int>();
            foreach (int i in source)
            {
                queue.Push(i);
            }

            while(!queue.IsEmpty())
            {
                Console.WriteLine(queue.Pop());
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            array.ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }
    }
}
