namespace MyFourthConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = ReadNumberUntilSuccess(1);
            double b = ReadNumberUntilSuccess(2);
            double c = ReadNumberUntilSuccess(3);

            Console.WriteLine($"Average number: {(a + b + c) / 3}");

        }

        static double ReadNumberUntilSuccess(int numberIdx)
        {
            Console.WriteLine($"Enter {numberIdx} number");

            while(true)
            {
                string? text = Console.ReadLine();
                if (double.TryParse(text, out var number))
                {
                    return number;
                } else
                {
                    Console.WriteLine($"Text '{text}' is not correct number. Please, try again");
                }
              
            }
        }
    }
}
