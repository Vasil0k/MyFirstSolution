namespace Homework4Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            while (true)
            {
                Console.WriteLine("Were to move? 'e' to exit");
                var key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Moving left");
                        break;
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Moving up");
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Moving down");
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Moving right");
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Exit the programm");
                        return;
                    default:
                        Console.WriteLine("Don't know where to move");
                        break;
                }
               
            }
        }
    }
}
