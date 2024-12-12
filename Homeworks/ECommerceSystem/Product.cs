namespace ECommerceSystem
{
    public abstract class Product
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            private set { _price = value; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product {Name} has price {Price:F2}");
        }

        public abstract decimal GetDiscountedPrice();
    }
}
