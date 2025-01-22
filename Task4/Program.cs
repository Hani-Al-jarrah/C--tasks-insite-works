using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    internal class Program
    {
        class Student
        {
            private string name;
            private int age;
            private int studentID;
            public string Email { get; set; } // auto proparity
            public const double MinAge = 18;
            public const double MaxAge = 40;


            public void GetDetails() //method for printing
            {
                Console.WriteLine($"\nStudent Name: {name}, Age: {age}, Student ID: {studentID}, Email: {Email}");
            }

            public Student()
            { // default Constructor with initial values
                name = "";
                age = 18;
                studentID = 0;
            }

            public Student(string name, int age, int studentID) // Constructor with Paramiters
            {

                if (age < MinAge || age > MaxAge) // check the age 
                {
                    Console.WriteLine($"\nInvalid age: {age}. Age must be between {MinAge} and {MaxAge}.");
                }
                else
                {
                    this.name = name;
                    this.age = age;
                    this.studentID = studentID;
                }
            }

            ~Student() //Destructor
            {
                Console.WriteLine($"\nStudent object with ID {studentID} is being destroyed."); // will call it every time i create object 
            }

            ///----------------------------------set & get Name-------------------------------------
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            ///----------------------------------set & get Age-------------------------------------
            public int Age
            {
                get { return age; } // return it value
                set
                {
                    if (value >= MinAge && value <= MaxAge) // check the age 
                    {
                        age = value; // assigned a value for it
                    }
                    else
                    {
                        Console.WriteLine($"\nInvalid age: {value}. Age must be between {MinAge} and {MaxAge}.");
                    }
                }
            }

            ///----------------------------------set & get StudentID-------------------------------------
            // Property for StudentID
            public int StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }


            static void Main(string[] args)
            {
                ///-----------------------------Creating Objects------------------------------------------
                Student student = new Student("Ahmad", 2, 1001);
                student.Email = "Ahmad@gmail.com"; // add value to the email 
                student.GetDetails(); // call the method for print

                Student student2 = new Student("hani", 22, 1002);
                student2.Email = "hani@gmail.com"; // add value to the email
                student2.GetDetails(); // call the method for print

            }





        }
    }
}



/* 
Q1) A class is a blueprint or template for creating objects. we defines in it the properties and methods.
Q2)An object is an instance of a class.
Q3)class : A blueprint or template , Defines structure  ||Object : An instance of a class , Represents actual data
Q4) 1. Encapsulation 2. Inheritance 3.	Polymorphism 4.	Abstraction
Q5)private field. It uses get and set accessors.
Q6)A field is a variable declared directly in a class. It holds the state or data of an object.
Q7)A constructor is a special method in a class that is automatically called when an object is created. It is used to initialize the object's fields or properties.
Q8)Encapsulation in C# is a mechanism that combines data and methods into a single unit called a class , It's a way to organize and protect your data and methods.  
 */