namespace Homework8.task2
{
    public abstract class Transport
    {
        public Engine Engine { get; set; }

        public Transport(Engine engine)
        {
            Engine = engine;
        }

        public abstract void Move();
    }
}
