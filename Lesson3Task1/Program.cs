namespace Lesson3Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius r:");
            double radius = ReadNumberUntilSuccess();

            Console.WriteLine("Enter cone generatrix l: ");
            double coneGeneratrix = ReadNumberUntilSuccess();

            double s = Math.PI * radius * (radius + coneGeneratrix);

            Console.WriteLine($"cone surface area is {s}");
        }

        static double ReadNumberUntilSuccess()
        {
            while (true)
            {
                string? text = Console.ReadLine();
                if (double.TryParse(text, out var number))
                {
                    if (number <= 0)
                    {
                        Console.WriteLine("Number can not be negative. Please, try again");
                        continue;
                    }
                    return number;
                }
                else
                {
                    Console.WriteLine($"Text '{text}' is not correct number. Please, try again");
                }
            }
        }
    }
}
