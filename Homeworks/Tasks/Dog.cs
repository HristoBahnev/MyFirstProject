namespace Lecture8
{
    public class Dog : Animal
    {
        public Dog()
        {
        }

        public Dog(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }

        public void Bark()
        {
            Console.WriteLine("barking...");
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}\nDJAAF";
        }
    }
}
