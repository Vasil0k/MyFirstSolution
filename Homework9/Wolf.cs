namespace Homework9
{
    public class Wolf : Predator
    {
        public override void Bite()
        {
            Console.WriteLine("Wolf is hungry");
            base.Bite();
        }
    }
}
