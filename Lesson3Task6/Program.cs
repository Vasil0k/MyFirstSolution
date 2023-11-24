namespace Lesson3Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 18, 36, 42 };
            Console.WriteLine(NumberUtils.FindGcd(arr));

            NumberUtils.ProcessThreeDigitNumber(4562);
        }
    }
}
