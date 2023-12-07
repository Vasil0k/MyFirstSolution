namespace Homework4Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salary = 500M;
            TaxUtlils.CalculateIncomeTax(salary, out decimal tax);
            Console.WriteLine($"Income tax for {salary} is {tax}");
        }
    }
}
