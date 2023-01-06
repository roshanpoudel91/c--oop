using System;

public abstract class Bird

{
    public abstract void color();

    public void fly()
    {
        Console.WriteLine("Bird is flying...");
    }

}

public class Peacock : Bird
{
    public override void color()
    {
        Console.WriteLine("Peacock color is blue");
	}
}

public class Abstraction
{
    public static void Main(string[] args)
    {
        Peacock peacock = new Peacock();

        peacock.color();
        peacock.fly();

        Console.ReadKey();
    }
}


