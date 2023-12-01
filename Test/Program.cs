using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test
{
    internal class Program
    {/*
        2 задача.Дано: у вас есть 3 промежутка чисел: от 0 до 30, от 31 до 60 и от 61 до 100.
Входной параметр: пользователь вводит число.
        Что мы делаем: нужно понять в какой промежуток попало число.
Выводим на консоль: в каком промежутке число.Если не попало, пишем “Don’t know this number.”*/
        static void Main(string[] args)
        {
            Start:
            if (int.TryParse(Console.ReadLine(), out var number)) 
            {
                if (number >= 0 && number <= 30)
                {
                    Console.WriteLine("number from 0 to 30");
                } 
                else if (number > 30 && number <= 60)
                {
                    Console.WriteLine("number from 31 to 60");
                } 
                else if (number > 60 && number <= 100)
                {
                    Console.WriteLine("number from 61 to 100");
                } 
                else
                {
                    Console.WriteLine("Don’t know this number.");
                }
            } 
            else
            {
                goto Start;
            }
        }
    }
}
