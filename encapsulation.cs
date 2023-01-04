using System;

namespace myApplication{
class encapsulation
{
    public static void Main(string[] args){
        Person roshan = new Person();
        roshan.Name = "Roshan";
        Console.WriteLine("Text here");
        Console.ReadKey();
    
    }

}

class Person{
    string name;

    public string Name{
        get{return name;}
        set{name = value;}

    }
    
}

}



