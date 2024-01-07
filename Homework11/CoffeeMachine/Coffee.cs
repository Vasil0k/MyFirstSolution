namespace Homework11.CoffeeMachine
{
    public class Coffee(CoffeeStrength strength, int volume)
    {
        public CoffeeStrength Strength { get; set; } = strength;
        public int Volume { get; set; } = volume;

        public override string? ToString()
        {
            return $"Coffee: [strength: {Strength}; volume: {Volume}]";
        }
    }
}
