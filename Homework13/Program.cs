using Homework13.Task2;
using System.Collections.ObjectModel;

namespace Homework13
{
    internal class Program
    {
        private static Dictionary<int, string> dictionary = new Dictionary<int, string>()
        {           
            {1, "apple" },
            {2, "banana" },
            {3, "orange" },
            {4, "grape" },
            {5, "kiwi" },
            {6, "mango" },
            {7, "pear" },
            {8, "cherry" },
            {9, "strawberry" },
            {10, "blueberry" }
        };
        static void Main(string[] args)
        {
            //TASK 1
            foreach (var word in GetWordIterator(GenerateWordList(3)))
            {
                Console.WriteLine(word);
            }

            //TASK 2
            CustomCollection<Item> items = new();
            items.Add(new ItemImpl(50));
            items.Add(new ItemImpl(100));
            items.Add(new ItemImpl(70));
            items.Add(new ItemImpl(20));
            items.Add(new ItemImpl(500));
        }

        public static List<string> GenerateWordList(uint wordsNumber)
        {
            List<string> words = [];
            while (words.Count != wordsNumber)
            {
                int randomNumber = new Random().Next(1, dictionary.Count + 1);
                words.Add(dictionary[randomNumber]);
            }
            return words;
        }

        public static IEnumerable<string> GetWordIterator(ICollection<string> words)
        {
            foreach (var word in words.Where(w => w.Length > 5))
            {
                yield return word;
            }
        }
    }
}
