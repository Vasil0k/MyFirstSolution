namespace Homework5Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacci(10));
            Console.WriteLine(GetFactorial(1000));
        }

        public static uint GetFibonacci(uint n)
        {
            if (n == 0)
            {
                return 0;
            } 
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 2) + GetFibonacci(n - 1);
            }
        }

        public static ulong GetFactorial(ulong number)
        {
            if (number == 0)
            {
                return 1;
            }

            return checked(number * GetFactorial(--number));
        }
    }
}
