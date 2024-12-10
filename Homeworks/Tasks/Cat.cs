namespace Lecture8
{
    public class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }

        public void Meow()
        {
            Console.WriteLine("meowing...");
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nMEEOW";
        }
    }
}
