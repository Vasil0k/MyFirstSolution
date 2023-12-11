namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string[] array = { };
            PrintArray(array);
            string[] newArray = AddValueToArray(array, "new", out bool isInserted);
            PrintArray(newArray);

            //Task 2
            int[,] intArr1 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 } };
            int[,] intArr2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 } };
            Console.WriteLine("matrix A:");
            PrintMatrix(intArr1);
            Console.WriteLine("matrix B");
            PrintMatrix(intArr2);
            int[,] sum = SumMatrix(intArr1, intArr2);
            Console.WriteLine("Sum Matrix:");
            PrintMatrix(sum);
        }

        static string[] AddValueToArray(string[] arr, string value, out bool isInserted)
        {
            if (string.IsNullOrEmpty(value))
            {
                isInserted = false;
                return arr;
            }

            if (arr == null || arr.Length == 0)
            {
                isInserted = true;
                return [value];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (string.IsNullOrEmpty(arr[i]))
                {       
                    arr[i] = value;
                    isInserted = true;
                    return arr;
                }
            }

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
            isInserted = true;
            return arr;
        }

        static int[,] SumMatrix(int[,] a, int[,] b)
        {

            if (a.GetLength(0) == 0 || a.GetLength(0) != b.GetLength(0))
            {
                throw new ArgumentException($"rows number mismatch. rows a - {a.GetLength(0)}, rows b - {b.GetLength(0)}");
            }

            if (a.GetLength(1) == 0 || a.GetLength(1) != b.GetLength(1))
            {
                throw new ArgumentException($"columns number mismatch. columns a - {a.GetLength(0)}, columns b - {b.GetLength(0)}");
            }

            int[,] sum = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }

            return sum;
        }

        private static void PrintArray(object[] arr)
        {
            arr.ToList().ForEach(i => Console.WriteLine(i));
        }

        private static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
}
