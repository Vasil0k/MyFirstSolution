using Homework12.People;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = [];
            for (int i = 0; i < 10; i++)
            {
                Random random = new();
                people.Add(new Person((Gender) random.Next(0, 2), random.Next(10, 60)));
            }

            List<Person> sortedByComparable = new(people);
            sortedByComparable.Sort();

            List<Person> sortedByComparer = new(people);
            sortedByComparer.Sort(new PersonComparer());


            Console.WriteLine("Initial list");
            people.ForEach(Console.WriteLine);
           
            Console.WriteLine("Sorted list by Comparable");
            sortedByComparable.ForEach(Console.WriteLine);

            Console.WriteLine("Sorted list by Comparer");
            sortedByComparer.ForEach(Console.WriteLine);
        }
    }
}
