namespace Homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            List<int> sequence1 = new(){ -10, 22, 13, 43, -5, -12, 100 };
            List<int> filteredsequence1 = sequence1.Where(i => i < 0 && i % 2 == 0).Reverse().ToList();
            Console.WriteLine("Task 1");
            Console.WriteLine("Initial sequence");
            Print(sequence1);
            Console.WriteLine("Filtered sequence");
            Print(filteredsequence1);

            //Task 2
            List<string> sequence2 = new() { "Hello", "here", "we", "are" };
            List<char> filteredSequence2 = sequence2.Select(a => a[0]).Reverse().ToList();
            Console.WriteLine("Task 2");
            Console.WriteLine("Initial sequence");
            Print(sequence2);
            Console.WriteLine("Filtered sequence");
            Print(filteredSequence2);

            //Task 3
            List<int> sequence3 = new() { 11, -1, -20, 20, -5, 4, 5, 8, -1, 9, 2, 0, -11, 15, 3, -3, 4, 0, 20 };
            List<int> filteredSequence3a = sequence3.Where(i => i > 0).ToList();
            List<int> filteredSequence3b = sequence3.Where(i => i % 2 != 0).Distinct().ToList();
            List<int> filteredSequence3c = sequence3.Where(i => i < 0 && i % 2 == 0).Reverse().ToList();
            List<int> filteredSequence3d = sequence3.Where(i => i > 9 && i < 100).Order().ToList();
            Console.WriteLine("Task 3");
            Console.WriteLine("Initial sequence");
            Print(sequence3);
            Console.WriteLine("Filtered sequence a");
            Print(filteredSequence3a);
            Console.WriteLine("Filtered sequence b");
            Print(filteredSequence3b);
            Console.WriteLine("Filtered sequence c");
            Print(filteredSequence3c);
            Console.WriteLine("Filtered sequence d");
            Print(filteredSequence3d);

            //Task 4             
            List<Client> clients = Enumerable.Range(1, 200).Select(i => new Client(i)).ToList(); 
            var mostLoaded = clients.GroupBy(c => c.Year)
                .Select(group => new { Year = group.Key, ToatalDuration = group.Sum(c => c.TrainingDuration) })
                .OrderByDescending(e => e.ToatalDuration)
                .ThenBy(e => e.Year)
                .FirstOrDefault();

            Console.WriteLine("Task 4");
            Console.WriteLine("Initial sequence");
            Print(clients);
            Console.WriteLine($"The most loaded year is {mostLoaded.Year} with totalDuration {mostLoaded.ToatalDuration}");

            //Task 5
            List<string> list = new() { "one", "two", "three" };
            Console.WriteLine(list.Median());

        }

        static void Print<T>(IEnumerable<T> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }        
    }

    internal class Client
    {     
        private static Random _random = new Random();
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TrainingDuration { get; set; }

        public Client(int id) 
        {
            Id = id;
            Year = _random.Next(2010, 2025);
            Month = _random.Next(1, 13);
            TrainingDuration = _random.Next(0, 500);
        }

        public override string? ToString()
        {
            return $"Client: [Id: {Id}, Year: {Year}, Duration: {TrainingDuration}]";
        }
    }
}
