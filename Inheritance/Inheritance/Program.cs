using System;

namespace Inheritance{
    class Vehicle
    {
        public string brand = "Honda";

        public void honk()
        {
            Console.WriteLine("Pi pi..");
        }
    }

    class Car: Vehicle
    {
        public string modelName = "Toyota";

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.WriteLine(myCar.brand);

            Console.WriteLine(myCar.modelName);

            myCar.honk();

            Console.ReadKey();



        }
    }
}
