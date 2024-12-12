namespace ZooAnimals
{
    public abstract class Animal
    {

        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public abstract void MakeSound();
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

    }
}
