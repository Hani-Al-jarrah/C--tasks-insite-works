using System;

namespace Insite_1_20_2025_OOP_
{
    // Class definition (a blueprint for creating objects)
    //public class Person
    //{
    //    // Fields (variables for the object)
    //    public string Name; // Field to store the person's name
    //    public int Age;     // Field to store the person's age

    //    // Constant (fixed value shared across all objects)
    //    public const string Species = "Homo sapiens"; // All humans are of this species

    //    // Static Field (shared across all objects, can be changed)
    //    public static int Population = 0; // Keeps track of the total population

    //    // Instance Method (belongs to an object)
    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine($"Name: {Name}, Age: {Age}");
    //    }

    //    // Static Method (belongs to the class, not an object)
    //    public static void DisplayPopulation()
    //    {
    //        Console.WriteLine($"Current Population: {Population}");
    //    }
    //}

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Class vs Object:
    //        // The class is the blueprint (e.g., Person), and objects are the instances (e.g., person1, person2).
    //        Console.WriteLine("Class vs Object:");
    //        Console.WriteLine("Class: Defines structure and behavior (e.g., Person)");
    //        Console.WriteLine("Object: Instances created from the class (e.g., person1, person2)");

    //        // Declaring objects of the class
    //        Person person1 = new Person(); // Creating the first person object
    //        person1.Name = "Alice";       // Setting fields manually
    //        person1.Age = 30;
    //        Person.Population++;          // Incrementing static field manually

    //        Person person2 = new Person(); // Creating the second person object
    //        person2.Name = "Bob";         // Setting fields manually
    //        person2.Age = 25;
    //        Person.Population++;          // Incrementing static field manually

    //        // Accessing instance methods
    //        Console.WriteLine("\nInstance Method (Details of Each Person):");
    //        person1.DisplayDetails();
    //        person2.DisplayDetails();

    //        // Accessing static methods and fields
    //        Console.WriteLine("\nStatic Field and Method (Shared Across All Objects):");
    //        Person.DisplayPopulation();

    //        // Accessing the constant
    //        Console.WriteLine("\nConstant Field (Fixed Value for All Objects):");
    //        Console.WriteLine($"Species (Constant): {Person.Species}");

    //        // Difference between Constant and Static:
    //        Console.WriteLine("\nDifference between Constant and Static:");
    //        Console.WriteLine("- Constant 'Species': Fixed value, cannot change.");
    //        Console.WriteLine("- Static 'Population': Shared among all objects, value changes as objects are created.");

    //        // End of program
    //        Console.WriteLine("\nProgram End.");
    //    }
    //}

    //class Car
    //{
    //    string model;
    //    string color;
    //    int year;

    //    const int wheels = 4;

    //    public static void DisplayInfo(Car c)
    //    {
    //        Console.WriteLine($"car: {c.model} {c.color}, made in : {c.year}, number of the wheels: {wheels}");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Car Ford = new Car();
    //        Ford.model = "Mustang";
    //        Ford.color = "red";
    //        Ford.year = 1969;

    //        Car Opel = new Car();
    //        Opel.model = "Astra";
    //        Opel.color = "white";
    //        Opel.year = 2005;


    //        Console.WriteLine(Ford.model);
    //        Console.WriteLine(Car.wheels);

    //        Car.DisplayInfo(Ford);
    //    }
    //}


    //using System;

    //// Base class
    //public class Animal
    //{
    //    protected int owner { get; set; }  //protected Proparity 
    //    public void Eat()
    //    {
    //        owner = 0;
    //        Console.WriteLine("This animal is eating.");
    //    }

    //}

    //// Derived class
    //public class Dog : Animal
    //{
    //    //owner = "hani";
    //    //owner=2*3;

    //    public void Bark()
    //    {
    //        owner = 2*3 ;
    //        Console.WriteLine(owner);
    //        Console.WriteLine("of this dog.");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog dog1 = new Dog();
    //        //dog1.owner="hani";
    //        dog1.Bark();

    //        dog1.Eat();



    //        //// Create an object of the derived class
    //        //Dog myDog = new Dog();

    //        //// Access the base class method
    //        //myDog.Eat();


    //        //// Access the derived class method
    //        //myDog.Bark();
    //    }
    //}



    //using System;

    //// Abstract class defining the MediaPlayer structure
    // class MediaPlayer
    //{
    //    public  virtual void Play()
    //    {
    //        Console.WriteLine("Playing audio1...");
    //    }

    //    public virtual void Pause()
    //    {
    //        Console.WriteLine("Playing audio1...");

    //    }
    //    public virtual void Stop()
    //    {

    //        Console.WriteLine("Playing audio1...");
    //    }
    //}

    //// Concrete class for AudioPlayer
    //class AudioPlayer : MediaPlayer
    //{
    //    public override void Play()
    //    {
    //        Console.WriteLine("Playing audio...");
    //    }

    //    public override void Pause()
    //    {
    //        Console.WriteLine("Pausing audio...");
    //    }

    //    public override void Stop()
    //    {
    //        Console.WriteLine("Stopping audio...");
    //    }
    //}

    //// Concrete class for VideoPlayer
    //class VideoPlayer : MediaPlayer
    //{
    //    public override void Play()
    //    {
    //        Console.WriteLine("Playing video...");
    //    }

    //    public override void Pause()
    //    {
    //        Console.WriteLine("Pausing video...");
    //    }

    //    public override void Stop()
    //    {
    //        Console.WriteLine("Stopping video...");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        MediaPlayer player = new AudioPlayer();  // override
    //        player.Play();
    //        player.Pause();
    //        player.Stop();

    //        MediaPlayer player1 = new VideoPlayer();
    //        player.Play();
    //        player.Pause();
    //        player.Stop();
    //    }
    //}


    using System;

    // Abstract class defining the MediaPlayer structure
    abstract class MediaPlayer
    {
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }

    // Concrete class for AudioPlayer
    class AudioPlayer : MediaPlayer
    {
        public override void Play()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Playing audio...");
            }
        }

        public override void Pause()
        {
            Console.WriteLine("Pausing audio...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping audio...");
        }
    }

    // Concrete class for VideoPlayer
    class VideoPlayer : MediaPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Playing video...");

        }

        public override void Pause()
        {
            Console.WriteLine("Pausing video...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping video...");
        }
    }

    class Program
    {
        static void Main()
        {
            MediaPlayer player = new AudioPlayer();
            player.Play();
            player.Pause();
            player.Stop();

            //MediaPlayer m1 = new VideoPlayer();
            //m1.Pause();
            //m1.Play();
            //m1.Stop();


            //VideoPlayer videoPlayer = new VideoPlayer();
            //videoPlayer.Play();
            //videoPlayer.Pause();
            //videoPlayer.Stop();



            player = new VideoPlayer();
            player.Play();
            player.Pause();
            player.Stop();


        }
    }


    //public interface IVehicle
    //{
    //    void Drive();
    //    void Stop();
    //}

    //public class Car : IVehicle
    //{
    //    public void Drive()
    //    {
    //        Console.WriteLine("Car is driving.");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("Car has stopped.");
    //    }
    //}

    //public class bike : IVehicle
    //{
    //    public void Drive()
    //    {
    //        Console.WriteLine("My Bike Drive");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("My Bike Stop");
    //    }
    //} //public class Truck :bike , IVehicle
    //{
    //    public void Drive()
    //    {
    //        Console.WriteLine("My Bike Drive");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine("My Bike Stop");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IVehicle myCar = new Car();
    //        myCar.Drive();
    //        myCar.Stop();

    //        myCar = new bike();
    //        myCar.Stop();
    //        myCar.Drive();
    //    }
    //}
}


