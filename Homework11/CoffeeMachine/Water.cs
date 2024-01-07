namespace Homework11.CoffeeMachine
{
    public class Water(int temperature, int volume)
    {
        public int Temperature { get; set; } = temperature;
        public int Volume { get; set; } = volume;

        public static Coffee operator +(Water water, GroundGrains groundGrains)
        {
            CoffeeStrength strength = CalculateCoffeeStrength(water, groundGrains);
            int volume = water.Volume + groundGrains.Volume / 2;

            return new Coffee(strength, volume);
        }

        public static CoffeeStrength CalculateCoffeeStrength(Water water, GroundGrains groundGrains)
        {
            int e = (int)groundGrains.Strength * groundGrains.Volume * water.Temperature / water.Volume;
            if (e > 95)
            {
                return CoffeeStrength.Strong;
            } 
            else if (e < 65)
            {
                return CoffeeStrength.Mild;
            }

            return CoffeeStrength.Medium; 
        }

        public override string? ToString()
        {
            return $"Water: [temperature: {Temperature}; volume: {Volume}]";
        }
    }
}
