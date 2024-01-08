using Homework11.CoffeeMachine;
using Homework11.PandaTask;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda man = new Panda("Man", Gender.Male, Color.Black, 100, 20, 10);
            Panda girl = new Panda("Girl", Gender.Female, Color.White, 80, 10, 5);
            Console.WriteLine($"baby: {man + girl}");

            //Strong coffee
            Water water = new Water(90, 50);
            GroundGrains grains = new GroundGrains(CoffeeStrength.Strong, 20);

            Coffee coffee = grains + water;

            Console.WriteLine($"{water}{Environment.NewLine}{grains}{Environment.NewLine}{coffee}");

            //Mild coffee
            water = new Water(90, 50);
            grains = new GroundGrains(CoffeeStrength.Mild, 20);

            coffee = grains + water;

            Console.WriteLine($"{water}{Environment.NewLine}{grains}{Environment.NewLine}{coffee}");

            //Medium coffee
            water = new Water(90, 50);
            grains = new GroundGrains(CoffeeStrength.Medium, 20);

            coffee = grains + water;

            Console.WriteLine($"{water}{Environment.NewLine}{grains}{Environment.NewLine}{coffee}");

            //Strong coffee
            water = new Water(100, 20);
            grains = new GroundGrains(CoffeeStrength.Mild, 50);

            coffee = grains + water;

            Console.WriteLine($"{water}{Environment.NewLine}{grains}{Environment.NewLine}{coffee}");

        }
    }
}
