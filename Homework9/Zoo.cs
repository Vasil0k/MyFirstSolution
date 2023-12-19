namespace Homework9
{
    public class Zoo
    {
        private List<Animal> _predators = new List<Animal>();
        private List<Animal> _herbivores = new List<Animal>();

       
        public void AddAnimal(Animal animal)
        {
            if (animal is Predator)
            {
                _predators.Add(animal);
            }
            else if (animal is HerbivoreAnimal)
            {
                _herbivores.Add(animal);
            }
            else
            {
                Console.WriteLine("Unknown animal");
            }
        }
    }
}
