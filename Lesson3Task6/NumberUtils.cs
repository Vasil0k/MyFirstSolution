using System;

namespace Lesson3Task6
{
    internal class NumberUtils
    {
        public static int FindGcd(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                throw new ArgumentException("Array must have 2 or more elements");
            }

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result = FindGcd(result, array[i]);
            }

            return result;
        }

        public static int FindGcd(int a, int b) 
        { 
            if (b == 0)
            {
                return Math.Abs(a);
            }
            return FindGcd(b, a % b);
        }

        public static void ProcessThreeDigitNumber(int number)
        {
            number = Math.Abs(number);
            if (number < 100 || number > 999)
            {
                throw new ArgumentException($"number '{number}' is not three digit");
            }

            int units = number % 10;
            int tens = (number / 10) % 10;
            int houndreds = (number / 100) % 10;

            Console.WriteLine($"houndreds count: {houndreds}");
            Console.WriteLine($"tens count: {tens}");
            Console.WriteLine($"units count: {units}");
            Console.WriteLine($"product of digits is {units * tens * houndreds}");
            Console.WriteLine($"sum of digits is {units + tens + houndreds}");         
        }
    }
}
