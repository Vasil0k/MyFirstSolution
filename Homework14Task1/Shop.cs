namespace Homework14Task1
{
    internal class Shop
    {
        private List<Product> _products = [];
        private bool _isShopWorks = true;
        public Seller? Seller { get; set; }

        public Shop() { }

        public Shop (Seller seller)
        {
            Seller = seller;
        }

        public void AddProduct(Product product)
        {
            CheckState();
            if (this._products.Contains(product))
            {
                throw new ProductAlreadyExistsException();
            }
            this._products.Add(product);
        }

        public Product SellProduct(String productName, CreditCard card)
        {
            CheckState();
            Product? product = _products.Find(p => productName.Equals(p.Name));
            if (product == null)
            {
                throw new NoSuchProductException();
            }

            if (card.Amount < product.Price)
            {
                throw new InsufficientFundsException();
            }

            _products.Remove(product);
            return product;            
        }

        public void Liquidate()
        {
            if (_products.Any())
            {
                throw new InvalidOperationException("Shop has some products yet");
            }

            _isShopWorks = false;
            Seller = null;
        }

        private void CheckState()
        {
            if (!_isShopWorks)
            {
                throw new InvalidOperationException("Shop is closed");
            }

            if (Seller == null)
            {
                throw new NoSellerException();
            }
        }
    }
}
