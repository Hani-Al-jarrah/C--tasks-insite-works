using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1
{
    internal class Program
    {
        //class Hotel
        //{
        //    private int roomNumber; // private  field 
        //    public int RoomNumber { set; get; }   // proerty


        //    public Hotel()  // constructor  iniital  private field 
        //    {
        //        roomNumber = 0;
        //    }

        //    public Hotel(int n)
        //    {
        //        RoomNumber = n;
        //    }

        //    ~Hotel()  // optional 
        //    {
        //        Console.WriteLine("finish");
        //    }

        //}
        //static void Main(string[] args)
        //{

        //    Hotel hotel = new Hotel(3 ); // object 
        //    Hotel hotel1 = new Hotel(3 ); // object 
        //                                 // hotel.RoomNumber = 1;


        //    Console.WriteLine(hotel.RoomNumber);
        //}


        //class Person
        //{
        //    // Private field (data hiding)
        //    private string _name;

        //    // Public property (controlled access)


        //    public string Name    // create anew proparity for access the praivate one , has close name for the praivate one 
        //    {
        //        get { return _name; } // Getter to retrieve the value
        //        set { _name = value; } // Setter to set the value
        //    }
        //}

        //class Program1
        //{
        //    static void Main(string[] args)
        //    {

        //        Person person = new Person();

        //        person.Name = "John";

        //        Console.WriteLine($"Name: {person.Name}");
        //    }
        //}


        public class Hotel
        {
            public int roomNumber; // field
            public string roomType; // field
            private double price; // private field
            public bool isBooked; // field
            public const string hotelName = "Hotel"; // Constant

            // Public property to control access to 'price'
            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            // Constructor with parameter
            public Hotel(double initialPrice)
            {
                price = initialPrice;
            }
            public Hotel()
            {
                price = 10;
            }

            // Destructor
            ~Hotel()
            {
                Console.WriteLine("finish");
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                // Create Room1 with an initial price
                Hotel Room1 = new Hotel(0); // Use the constructor with a price parameter

                Console.WriteLine("Enter Room1 Details:");
                Room1.roomNumber = Convert.ToInt32(Console.ReadLine());
                Room1.roomType = Console.ReadLine();
                Room1.Price = Convert.ToDouble(Console.ReadLine()); // Use the Price property
                Room1.isBooked = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine($"{Room1.roomNumber} {Room1.roomType} {Room1.Price} {Room1.isBooked} {Hotel.hotelName}");

                //---------------------------------------------

                Console.WriteLine("Enter Room2 Details:");
                Hotel Room2 = new Hotel(0); // Use the constructor with a price parameter
                Room2.roomNumber = Convert.ToInt32(Console.ReadLine());
                Room2.roomType = Console.ReadLine();
                Room2.Price = Convert.ToDouble(Console.ReadLine()); // Use the Price property
                Room2.isBooked = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine($"{Room2.roomNumber} {Room2.roomType} {Room2.Price} {Room2.isBooked} {Hotel.hotelName}");
            }
        }

    }

}

