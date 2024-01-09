namespace Homework12.Animals
{
    internal class Zoo
    {
        private List<IHerbivore> _herbivores = [];
        private List<ICarnivore> _carnivores = [];

        public void AddCarnivore(ICarnivore carnivore)
        {
            _carnivores.Add(carnivore);
        }

        public void AddHerbivore(IHerbivore herbivore)
        {
            _herbivores.Add(herbivore);
        }

        public bool AddAnimal(Animal animal)
        {
            if (animal is ICarnivore)
            {
                _carnivores.Add((ICarnivore) animal);
                return true;
            } 
            else if (animal is IHerbivore)
            {
                _herbivores.Add((IHerbivore) animal);
                return true;
            }

            Console.WriteLine("Animal is unknown");
            return false;
        }
    }
}
