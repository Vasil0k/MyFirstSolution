namespace Homework12.Animals
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int NumOfLegs { get; set; }

        public abstract void DisplayAnimal();
    }
}
