namespace Homework4Task4
{
    internal class TaxUtlils
    {
        const decimal IncomeTax = 13M;

        public static bool CalculateIncomeTax(decimal salary, out decimal tax)
        {
            if (salary <= 0)
            {
                Console.WriteLine("Salary can not be negative or zero");
                tax = -1;
                return false;
            } 
            else
            {
                tax = (salary * IncomeTax) / 100;
                return true;
            }
        }
    }
}
