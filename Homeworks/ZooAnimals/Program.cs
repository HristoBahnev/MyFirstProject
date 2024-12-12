using ZooAnimals;

public class Program
{
    static void Main(string[] args)
    {
        List<Animal> Animals = new List<Animal>
        {
            new Cat("Maca"),
            new Dog("Sharo")
        };

        foreach (Animal a in Animals)
        {
            a.MakeSound();
            a.Eat();
        }
    }
}

