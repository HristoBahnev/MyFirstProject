
namespace ECommerceSystem
{
    public class Electronics : Product
    {
        const decimal discount = 10;
        public Electronics(string name, decimal price) : base(name, price)
        {
        }

        public override decimal GetDiscountedPrice()
        {
            return Price * ((100 - discount) / 100);
        }
    }
}
