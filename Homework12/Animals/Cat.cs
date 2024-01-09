namespace Homework12.Animals
{
    internal class Cat : Animal, ICarnivore
    {
        private string _typeC;
        private string _foodC;
        public string TypeC { get => _typeC; set => _typeC = value; }
        public string FoodC { get => _foodC; set => _foodC = value; }

        public string Sound { get; set; }
        public string Color { get; set; }

        public Cat(string sound, string color)
        {
            Sound = sound;
            Color = color;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"I am a Cat. My name is {Name}.");
        }

        public void DisplayEatC()
        {
            Console.WriteLine($"I eat {FoodC}"); ;
        }
    }
}
