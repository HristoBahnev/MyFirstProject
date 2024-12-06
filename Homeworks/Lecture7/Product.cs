namespace Lecture7
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;
        public Product()
        {
            Name = "Beer";
            Price = 0;
            Quantity = 0;

        }
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal CalculateTotalCost(decimal price, int quantity)
        {
            return price * quantity;
        }
    }
}