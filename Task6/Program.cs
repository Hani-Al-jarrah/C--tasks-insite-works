using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        class Calculator
        {

            public int Add(int a, int b) { return a + b; }
            public double Add(int a, int b, int c) { return a + b + c; }
            public double Add(double a, double b) { return a + b; }
        }

        //----------------------------------------------------------------

        class Shape
        {
            public virtual void draw() { Console.WriteLine("Shape"); }

        }

        class Circle : Shape
        {

            public override void draw() { Console.WriteLine("Drawing a Circle."); }
        }
        class Rectangle : Shape
        {

            public override void draw() { Console.WriteLine("Drawing a Rectangle."); }
        }


        //----------------------------------------------------------------

        public abstract class Animal
        {

            public abstract void makeSound();
            public void sleep() { Console.WriteLine("Animal is sleeping."); }

        }

        public class Dog : Animal
        {
            public override void makeSound() { Console.WriteLine("Dog barks."); }
        }
        public class Cat : Animal
        {
            public override void makeSound() { Console.WriteLine("Cat meows."); }
        }

        //----------------------------------------------------------------

        interface IPlayble
        {
            void play();
        }

        public class Guitar : IPlayble
        {
            public void play() { Console.WriteLine("Playing the guitar."); }

        }
        public class Piano : IPlayble
        {
            public void play() { Console.WriteLine("Playing the piano."); }

        }


        static void Main(string[] args)
        {
            IPlayble playble = new Piano();
            playble.play();

            playble = new Guitar();
            playble.play();

            Animal animal = new Cat();
            animal.makeSound();
            animal.sleep();

            animal = new Dog();
            animal.makeSound();
            animal.sleep();

            Shape shape = new Circle();
            shape.draw();

            shape = new Rectangle();
            shape.draw();


            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 1));
            Console.WriteLine(calculator.Add(1, 1, 1));
            Console.WriteLine(calculator.Add(1.1, 1.1));
        }
    }
}
