namespace Homework9
{
    public class Predator : Animal
    {
        public override void Live()
        {
            while (true)
            {
                if (IsHungry)
                {
                    Bite();
                }
                else
                {
                    Console.WriteLine("I am not hungry.");
                }
            }
        }

        public virtual void Bite()
        {
            Console.WriteLine("catching prey...");
            IsHungry = false;
        }
    }
}
