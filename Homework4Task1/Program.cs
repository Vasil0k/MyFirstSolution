namespace Homework4Task1
{
    internal class Program
    {   
        const int From = 200;
        const int To = 500;

        static void Main(string[] args)
        {
            List<int> numbers = [];
            int number = From + 1;
            while (number > From && number < To)
            {
                if (number % 17 == 0)
                {
                    numbers.Add(number);
                }
                number++;
            }
            Console.WriteLine($"Numbers, which can be divided by 17 from {From} to {To} are:{Environment.NewLine}{string.Join(", ", numbers)}");
        }
    }
}
