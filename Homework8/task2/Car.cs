namespace Homework8.task2
{
    public class Car : Transport
    {
        public Car(Engine engine) : base(engine) { }
        
        public override void Move()
        {
            Engine.StartEngine();
            Console.WriteLine("The car is moving...");
        }
    }
}
