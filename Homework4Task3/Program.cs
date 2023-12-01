namespace Homework4Task3
{
    internal class Program
    {
        const int Range = 1000;

        static void Main(string[] args)
        {
            int arraySize = new Random().Next(Range);
            Console.WriteLine($"array size is {arraySize}");

            while (arraySize == 0) 
            {
                Console.WriteLine("array size can not be 0. Trying regenerate new array size value");
                arraySize = new Random().Next(Range);
                Console.WriteLine($"new array size is {arraySize}");
            }

            List<int> numbers = []; 
            for (int i = 0; i < arraySize; i++)
            {
                numbers.Add(new Random().Next(Range));
            }

            int index = 0;
            StartLoop:
            if (index < numbers.Count)
            {
                int currentNumber = numbers[index];
                Console.WriteLine($"Current number is {currentNumber}");
                index++;
                goto StartLoop;
            }
        }
    }
}
