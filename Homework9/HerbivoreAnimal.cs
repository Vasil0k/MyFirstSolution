namespace Homework9
{
    public class HerbivoreAnimal : Animal
    {
        public override void Live()
        {
            while (true)
            {
                if (IsHungry)
                {
                    EatGrass();
                }
                else
                {
                    Console.WriteLine("I am not hungry.");
                }
            }
        }

        public virtual void EatGrass() 
        {
            Console.WriteLine("Eating grass...");
            IsHungry = false;
        }
    }
}
