public class Animal
{
    public  virtual void Sound()
    {
        Console.WriteLine("Animal make sound");
    }
}

public class Pig : Animal
{
    public  override void Sound()
    {
        Console.WriteLine("Pig sound: pee pee");
    }
}

public class Dog : Animal
{
    public  override void Sound()
    {
        Console.WriteLine("Dog sound: bhau bhau");
    }
}

public class Polymorphism
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Sound();

        Dog dog = new Dog();
        dog.Sound();

        Pig pig = new Pig();
        pig.Sound();


    }
}
