using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public void Start() { Console.WriteLine($"Vehicle is starting \n {Brand} , {Model} "); }


        }


        class Car : Vehicle
        {

            public int NumberOfDoors { get; set; }

        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.NumberOfDoors = 4;
            car.Model = "A8";
            car.Brand = "Audi";
            car.Start();

            Vehicle vehicle = new Vehicle();
            vehicle.Model = "M4";
            vehicle.Brand = "BMW";
            vehicle.Start();
        }
    }
}


/* 
Q1)A constructor is a special method in a class that is automatically called when an object is created. It is used to initialize the object's fields or properties. 
Q2) 1. Encapsulation 2. Inheritance 3.	Polymorphism 4.	Abstraction
Q3)Encapsulation in C# is a mechanism that combines data and methods into a single unit called a class , It's a way to organize and protect your data and methods.  
Q4)Sealed Class: A sealed class cannot be inherited. This ensures that no other class can extend its functionality.
Q5)class can inherit properties and behaviours (METHODS) from another class , with a superclass (also called a base class or parent class) and one or more subclasses (also known as derived classes or child classes)
 */
