namespace ECommerceSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
        {
            new Electronics("Oven", 555.55m),
            new Clothing("Skirt", 66),
        };

            foreach (var product in products)
            {
                product.DisplayInfo();
                Console.WriteLine($"Discounted Price: {product.GetDiscountedPrice():F2}\n");
            }
        }
    }
}
