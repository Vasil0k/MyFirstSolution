namespace Homework9
{
    public class Rabbit : HerbivoreAnimal
    {
        public override void EatGrass()
        {
            Console.WriteLine("Rabbit is hungry");
            base.EatGrass();
        }
    }
}
