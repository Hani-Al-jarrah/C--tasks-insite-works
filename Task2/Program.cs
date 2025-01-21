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

            //Console.WriteLine("\nEnter two numbers:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2) { Console.WriteLine("Equla"); }
            //else if (num1 > num2) { Console.WriteLine("Grater"); }
            //else { Console.WriteLine("Smaller"); }

            //////////////////////////////////////////////////////Q10///////////////////////////////////////////////////////


            //Console.WriteLine("\nEnter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Sum of digits: {SumOfDigits(num)}");

            //////////////////////////////////////////////////////Q11///////////////////////////////////////////////////////


            //Console.WriteLine("\nEnter a number:");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Reversed Number: {ReverseNumber(num)}");

            //////////////////////////////////////////////////////Q12///////////////////////////////////////////////////////


            //Console.WriteLine("\nEnter two numbers (number and divisor):");
            //int dividend = Convert.ToInt32(Console.ReadLine());
            //int divisor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(CheckDivisibility(dividend, divisor));

            //////////////////////////////////////////////////////Q13///////////////////////////////////////////////////////


            //Console.WriteLine("\nEnter three numbers:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The middle value is: {FindMiddleValue(a, b, c)}");
        }



        //static int SumOfDigits(int num)
        //{
        //    // Convert the number to a string and split it into individual digits
        //    string numStr = num.ToString(); 
        //    int sum = 0;

        //    // Loop through each character, convert it back to an integer, and add to sum
        //    for (int i = 0; i < numStr.Length; i++)
        //    {
        //        sum += int.Parse(numStr[i].ToString()); // convert each char into string then into integer
        //    }

        //    return sum;
        //}

        //static int ReverseNumber(int num)
        //{
        //    string rev = "";
        //    string numStr = num.ToString();

        //    for (int i = numStr.Length - 1; i >= 0; i--)
        //    {
        //        rev += numStr[i];
        //    }

        //    return  Convert.ToInt32(rev);

        //}

        //static string CheckDivisibility(int dividend, int divisor)
        //{
        //    if (dividend % divisor == 0)
        //    {
        //        return "divisible";
        //    }
        //    else {
        //        return "Not Divisible";
        //    }
        //}

        //static int FindMiddleValue(int a, int b, int c)
        //{
        //    if ((a > b && a < c) || (a > c && a < b)) return a;
        //    if ((b > a && b < c) || (b > c && b < a)) return b;
        //    return c;
        //}

    }
}