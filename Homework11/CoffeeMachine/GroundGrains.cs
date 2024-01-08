namespace Homework11.CoffeeMachine
{
    public class GroundGrains(CoffeeStrength strength, int volume)
    {
        public CoffeeStrength Strength { get; set; } = strength;
        public int Volume { get; set; } = volume;       

        public static Coffee operator +(GroundGrains groundGrains, Water water)
        {
            return water + groundGrains;
        }

        public override string? ToString()
        {
            return $"GroundGrains: [strength: {Strength}; volume: {Volume}]";
        }
    }
}
