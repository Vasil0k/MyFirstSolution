namespace Homework13.Task2
{
    internal class CustomCollection<T> where T : Item
    {
        private List<T> items = [];

        public void Add(T item)
        {
            items.Add(item);
            items.Sort();
            items.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("------------------");
        }
    }
}
