namespace Homework9
{
    public class Deer : HerbivoreAnimal
    {
        public override void EatGrass()
        {
            Console.WriteLine("Deer is hungry");
            base.EatGrass();
        }
    }
}
