namespace Homework14Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = ReadFromConsole();
            Console.WriteLine("enter second number");
            int b = ReadFromConsole();
            if (b == 0)
            {
                throw new ArgumentException("divider must be not equal zero");
            }

            Console.WriteLine($"division result: {a / (decimal)b}");
        }

        static int ReadFromConsole()
        {
            while (true)
            {
                try
                {
                    int number =  int.Parse(Console.ReadLine());
                    if (number < 0 || number > 255)
                    {
                        throw new ArgumentException("number should be between 0 and 255");
                    }
                    return number;
                }
                catch (Exception e) 
                {
                    Console.WriteLine($"{e.Message}. Try again");
                }
            }
            
        }

        static void CheckRange(int x)
        {
           
        }
    }
}
