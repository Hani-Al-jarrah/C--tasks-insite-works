﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {

        //static void EvenOrOdd()
        //{
        //    Console.WriteLine("Enter an integer:");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"The number {num} is {(num % 2 == 0 ? "even" : "odd")}.");
        //}
        ////////////////////////////
        //static void SecondSmallest()
        //{
        //    Console.WriteLine("Enter five numbers separated by spaces:");
        //    string input = Console.ReadLine();
        //    string[] parts = input.Split();
        //    int[] numbers = new int[5];

        //    for (int i = 0; i < 5; i++)
        //    {
        //        numbers[i] = int.Parse(parts[i]);
        //    }

        //    Array.Sort(numbers); // method for sort the array
        //    Console.WriteLine($"The second smallest number is: {numbers[1]}");

        //}
        ////////////////////
        //static void Factorial()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    int factorial = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        factorial *= i;
        //    }
        //    Console.WriteLine($"The factorial of {num} is: {factorial}");
        //}

        ////////////////

        //static void PrimeNumbers()
        //{
        //    Console.WriteLine("Enter start number:");
        //    int start = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter end number:");
        //    int end = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Prime numbers:");
        //    for (int i = start; i <= end; i++)
        //    {
        //        bool isPrime = true;
        //        for (int j = 2; j < i; j++)
        //            if (i % j == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //        if (i > 1 && isPrime)
        //        {
        //            Console.Write($"{i} ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        ///////////////////////////////////////

        //static void LargestInArray()
        //{
        //    int[] numbers = { 3, 1, 4, 1, 5, 9 };
        //    int max = numbers[0];

        //    foreach (int num in numbers)
        //    {
        //        if (num > max)
        //        { max = num; }
        //    }

        //    Console.WriteLine($"The largest number is: {max}");
        //}

        ///////////////////////////////////////

        //static void NumberPattern()
        //{
        //    int n = 5, count = 1;
        //    for (int i = 1; i <= n; i++)
        //    {

        //        for (int j = 1; j <= i; j++)
        //        {

        //            Console.Write(count++ + " ");

        //        }
        //        Console.WriteLine();
        //    }
        //}
        ///////////////////////////////////
        //static void PyramidPattern()
        //{
        //    Console.WriteLine("Enter pyramid height:");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i <= n; i++)
        //    {
        //        Console.Write(new string(' ', n - i));
        //        Console.WriteLine(new string('*', 2 * i - 1));
        //    }
        //}
        ///////////////////////////////////
        //static void RightTriangle()
        //{
        //    Console.WriteLine("Enter triangle height:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= n; i++) // Loop for each row
        //    {
        //        // Single inner loop for spaces and stars
        //        for (int j = 1; j <= n; j++)
        //        {
        //            if (j <= n - i) // Print spaces
        //            {
        //                Console.Write(" ");
        //            }
        //            else // Print stars
        //            {
        //                Console.Write("*");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        ///////////////////////////////////

        //static void SumEvenOdd()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6 };
        //    int sumEven = 0, sumOdd = 0;

        //    foreach (int num in numbers)
        //    {
        //        if (num % 2 == 0) { sumEven += num; }

        //        else { sumOdd += num; }
        //    }
        //    Console.WriteLine($"Sum of Even Numbers: {sumEven}");
        //    Console.WriteLine($"Sum of Odd Numbers: {sumOdd}");
        //}

        ///////////////////////////////////

        //static void CommonElements()
        //{
        //    int[] array1 = { 1, 2, 3, 4 };
        //    int[] array2 = { 3, 4, 5, 6 };

        //    Console.WriteLine("Common elements:");
        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        for (int j = 0; j < array2.Length; j++)
        //        {
        //            if (array1[i] == array2[j])
        //            {
        //                Console.Write($"{array1[i]} ");
        //                break;
        //            }
        //        }
        //    }
        //    Console.WriteLine();
        //}
        ////////////////////////////////////////////////////////


        //class Room
        //{
        //    public int RoomNumber;
        //    public string RoomType;
        //    public double PricePerNight;
        //    public bool IsBooked;

        //    public const string HotelName = "Grand Stay Hotel";

        //    public void PrintRoomDetails()
        //    {
        //        Console.WriteLine($"Hotel Name: {HotelName}");
        //        Console.WriteLine($"Room Number: {RoomNumber}");
        //        Console.WriteLine($"Room Type: {RoomType}");
        //        Console.WriteLine($"Price Per Night: {PricePerNight:C}");
        //        Console.WriteLine($"Booked: {(IsBooked ? "Yes" : "No")}");
        //        Console.WriteLine();
        //    }
        //}


        static void Main(string[] args)
        {



            //Console.WriteLine("Task 1: Even or Odd");
            //EvenOrOdd();
            ///////////////////////////
            //Console.WriteLine("\nTask 2: Second Smallest Number");
            //SecondSmallest();
            ///////////////////////////
            //Console.WriteLine("\nTask 3: Factorial");
            //Factorial();
            ////////////////////////
            //Console.WriteLine("\nTask 4: Prime Numbers Between Two Integers");
            //PrimeNumbers();
            /////////////////////////
            //Console.WriteLine("\nTask 5: Largest Number in Array");
            //LargestInArray();
            ///////////////////////////////////////
            //Console.WriteLine("\nTask 6: Number Pattern");
            //NumberPattern();
            /////////////////////////////////////
            //Console.WriteLine("\nTask 7: Pyramid Pattern");
            //PyramidPattern();
            ///////////////////////////////////
            //Console.WriteLine("\nTask 8: Sum of Even and Odd Numbers");
            //SumEvenOdd();
            ///////////////////////////////////
            //Console.WriteLine("\nTask 9: Common Elements in Arrays");
            //CommonElements();
            /////////////////////////////////
            //Console.WriteLine("\nTask 10: triangle");
            //RightTriangle();

            ///////////////////////////////////////////////////////////////////////////////////////////////////

           // Room[] rooms = new Room[2];

           //// Input details for 2 rooms
           // for (int i = 0; i < rooms.Length; i++)
           //     {
           //         Console.WriteLine($"Enter details for Room {i + 1}:");
           //         Console.Write("Room Number: ");
           //         int roomNumber = Convert.ToInt32(Console.ReadLine());

           //         Console.Write("Room Type (Single, Double, Suite): ");
           //         string roomType = Console.ReadLine();

           //         Console.Write("Price Per Night: ");
           //         double pricePerNight = Convert.ToDouble(Console.ReadLine());

           //         Console.Write("Is Booked (true/false): ");
           //         bool isBooked = Convert.ToBoolean(Console.ReadLine());

           //         rooms[i] = new Room
           //         {
           //             RoomNumber = roomNumber,
           //             RoomType = roomType,
           //             PricePerNight = pricePerNight,
           //             IsBooked = isBooked
           //         };
           //     }


           // // Print the details of all rooms
           // Console.WriteLine("\nRoom Details:");
           // foreach (var room in rooms)
           // {
           //     room.PrintRoomDetails();
           // }

        }
    }
}