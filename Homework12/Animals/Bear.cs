namespace Homework12.Animals
{
    internal class Bear : Animal, ICarnivore, IHerbivore
    {
        private string _typeC;
        private string _foodC;
        private string _typeH;
        private string _foodH;
        public string TypeC { get => _typeC; set => _typeC = value; }
        public string FoodC { get => _foodC; set => _foodC = value; }
        public string TypeH { get => _typeH; set => _typeH = value; }
        public string FoodH { get => _foodH; set => _foodH = value; }
        public string Sound { get; set; }
        public string Color { get; set; }

        public Bear(string sound, string color)
        {
            Sound = sound;
            Color = color;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"I am Bear. My name is {Name}");
        }

        public void DisplayEatC()
        {
            Console.WriteLine($"I eat{FoodC}");
        }

        public void displayEatH()
        {
            Console.WriteLine($"I eat{FoodH}");
        }
    }
}
