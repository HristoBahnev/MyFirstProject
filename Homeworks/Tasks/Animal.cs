namespace Lecture8
{
    public class Animal
    {
        private string Name;
        private string FavouriteFood;

        public Animal()
        {
        }

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favoriteFood;

        }
        public void Eat()
        {
            Console.WriteLine("eating...");
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favorite food is {FavouriteFood}.";
        }
    }
}
