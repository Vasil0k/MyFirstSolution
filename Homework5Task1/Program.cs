namespace Homework5Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMultiplicationTable(10, 10);
        }

        static void PrintMultiplicationTable(uint factor1, uint factor2MaxValue)
        {
            for (int i = 1; i <= factor2MaxValue; i++)
            {
                Console.WriteLine($"{factor1} * {i} = {factor1 * i}");
            }
        }
    }
}
