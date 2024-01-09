namespace Homework12.Animals
{
    internal class Elephant : Animal, IHerbivore, IEquatable<Elephant>
    {
        private string _typeH;
        private string _foodH;
        public string TypeH { get => _typeH; set => _typeH = value; }
        public string FoodH { get => _foodH; set => _foodH = value; }
        public int Size { get; set; }

        public string Sound { get; set; }
        public string Color { get; set; }

        public Elephant(string sound, string color)
        {
            Sound = sound;
            Color = color;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"I am Elephant. My name is {Name}");
        }

        public void displayEatH()
        {
            Console.WriteLine($"I eat{FoodH}");
        }

        public bool Equals(Elephant? other)
        {
            if (other == null) 
            {
                return false;
            };

            return Size == other.Size;
        }
    }
}
