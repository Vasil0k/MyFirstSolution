namespace Homework9
{
    public class Bear : Predator
    {
        public override void Bite()
        {
            Console.WriteLine("Bear is hungry");
            base.Bite();
        }
    }
}
