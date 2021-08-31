using System;

namespace ConsoleApp1Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Car myCar = new Car();

            myCar.make = " Ford ";
            myCar.model = " Fiesta ";
            myCar.mph = 0;
            myCar.mphChange = 20;

            Console.WriteLine("My Speed is " + myCar.mph);
            Console.WriteLine("Enter speed change :");
            myCar.mphChange = Convert.ToInt32(Console.ReadLine());
            myCar.mph = myCar.GoFast(myCar.mph, myCar.mphChange);
            Console.WriteLine("My Speed is " + myCar.mph);

            Car newCar = new Car();

            newCar.model = " Chevy ";
            newCar.make = " S10 ";

            string x = (myCar.make + myCar.model + "is my Car.");
            Console.WriteLine(x);

            string y = (newCar.make + newCar.model + "is my Car.");
            Console.WriteLine(y);
        }
    }
}

