namespace Homework8.task2
{
    public class Plane : Transport
    {
        public Plane(Engine engine) : base(engine) { }

        public override void Move()
        {
            Engine.StartEngine();
            Console.WriteLine("The plain is flying...");
        }
    }
}
