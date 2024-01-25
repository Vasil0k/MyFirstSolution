namespace Homework14Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shop shop = new Shop(new Seller());
                shop.AddProduct(new Product("Coffee", 50));
                shop.SellProduct("Coffee", new CreditCard(25));
            } catch (InsufficientFundsException e)
            {
                Console.WriteLine("Not enough money");
            }
        }
    }
}
