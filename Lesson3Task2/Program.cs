namespace Lesson3Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type a number or 'e' to exit:");
                string text = Console.ReadLine()??"";
                if (text.Equals("e"))
                {
                    Console.WriteLine("exit the programm");
                    break;
                } 
                else if (int.TryParse(text, out var number))
                {
                    if (number % 2 == 0) 
                    {
                        Console.WriteLine($"number {number} is even.");
                    } else
                    {
                        Console.WriteLine($"number {number} is odd.");
                    }
                }
                else
                {
                    Console.WriteLine($"'{text}' is not an integer value");
                }
            }
        }
    }
}
