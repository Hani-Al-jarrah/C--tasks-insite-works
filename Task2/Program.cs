using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////Q1///////////////////////////////////////////////////////

            //Console.WriteLine("Enter a double value:");
            //double di = Convert.ToDouble(Console.ReadLine());
            //int converteddi = (int)di;
            //Console.WriteLine($"Double: {di}");
            //Console.WriteLine($"Converted Int: {converteddi}");

            //////////////////////////////////////////////////////Q2///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter a number:");
            //int ni = Convert.ToInt32(Console.ReadLine());
            //string numberAsString = Convert.ToString(ni);
            //Console.WriteLine($"Your number is: {numberAsString}");

            //////////////////////////////////////////////////////Q3///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter a sentence:");
            //string sentence = Console.ReadLine();
            //Console.WriteLine($"Uppercase: {sentence.ToUpper()}");
            //Console.WriteLine($"Lowercase: {sentence.ToLower()}");

            //////////////////////////////////////////////////////Q4///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter your full name:");
            //string fullName = Console.ReadLine();


            //// Find the index of the first space
            //int spaceIndex = fullName.IndexOf(' ');

            //// Extract the first name and last name using Substring
            //string firstName = fullName.Substring(0, spaceIndex);
            //string lastName = fullName.Substring(spaceIndex + 1);

            //// Display the results using substring
            //Console.WriteLine($"First Name: {firstName}");
            //Console.WriteLine($"Last Name: {lastName}");
            //Console.WriteLine($"{ lastName.Length + firstName.Length}");


            //string[] nameParts = fullName.Split(' '); // split the name when the user write space

            //// each part store in index 
            //Console.WriteLine($"First Name: {nameParts[0]}");
            //Console.WriteLine($"Last Name: {nameParts[1]}");

            //// Another way to display the name after split 
            //foreach (string name in nameParts)
            //    Console.WriteLine(name);

            //Console.WriteLine($"Total Characters: {fullName.Length}");

            //////////////////////////////////////////////////////Q5///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter two integers:");
            //int int1 = Convert.ToInt32(Console.ReadLine());
            //int int2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Smaller Number: {Math.Min(int1, int2)}");

            //////////////////////////////////////////////////////Q6///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter speed in kilometers per hour:");
            //double kmph = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Miles per hour: {(kmph/1.6)}");

            //////////////////////////////////////////////////////Q7///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter hours:");
            //int hours = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter minutes:");
            //int minutes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Total: {((hours*60) + minutes)} minutes");

            //////////////////////////////////////////////////////Q8///////////////////////////////////////////////////////

            //Console.WriteLine("\nEnter total minutes:");
            //int totalMinutes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hours "+(totalMinutes/60) +"\t Minutes "+ (totalMinutes%60)  );

            //////////////////////////////////////////////////////Q9///////////////////////////////////////////////////////

            Console.WriteLine("\nEnter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2) { Console.WriteLine("Equla"); }
            else if (num1 > num2) { Console.WriteLine("Grater"); }
            else { Console.WriteLine("Smaller"); }

            //////////////////////////////////////////////////////Q10///////////////////////////////////////////////////////














        }
    }
}