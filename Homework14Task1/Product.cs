namespace Homework14Task1
{
    internal class Product
    {   
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Name == product.Name &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
