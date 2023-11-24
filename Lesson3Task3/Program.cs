namespace Lesson3Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 1;
            int z = 5;

            x += y - x++ * z;
            Console.WriteLine($"x: {x}\ny: {y}\nz: {z}\n");
            z = --x - y * 5;
            Console.WriteLine($"x: {x}\ny: {y}\nz: {z}\n");
            y /= x + 5 % z;
            Console.WriteLine($"x: {x}\ny: {y}\nz: {z}\n");
            z = x++ + y * 5;
            Console.WriteLine($"x: {x}\ny: {y}\nz: {z}\n");
            x = y - x++ * z;
            Console.WriteLine($"x: {x}\ny: {y}\nz: {z}\n");
        }
    }
}
