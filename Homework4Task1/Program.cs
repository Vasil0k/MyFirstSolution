namespace Homework4Task1
{
    internal class Program
    {   
        const int from = 200;
        const int to = 500;
        static void Main(string[] args)
        {
            List<int> numbers = [];
            int number = from + 1;
            while (number > from && number < to)
            {
                if (number % 17 == 0)
                {
                    numbers.Add(number);
                }
                number++;
            }
            Console.WriteLine($"Numbers, which can be divided by 17 from {from} to {to} are:{Environment.NewLine}{string.Join(", ", numbers)}");
        }
    }
}
