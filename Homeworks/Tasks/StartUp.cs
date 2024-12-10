namespace Lecture8
{
    public static class StartUp
    {
        public static void Main()
        {
            //task one
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            //task two
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            //task three
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

            //task four
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

            //task five
            Animal Maria = new Cat("Maria", "Whiskas");
            Animal Rex = new Dog("Rex", "Meat");
            Console.WriteLine(Maria.ExplainSelf());
            Console.WriteLine(Rex.ExplainSelf());

        }
    }
}