using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;

            Console.WriteLine(rect1.Area());
            Rectangle rect2 = new Rectangle(20, 40);

            Console.WriteLine(rect2.Area());

            Animal fox = new Animal("foxy", "wooooooo");
            fox.MakeSound();
            Console.WriteLine("Number of animals {0}", Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("triangle", 5, 6));

            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("Rand number is null");
            }
        }
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double length = 1, double width = 1)
            {
                this.length = length;
                this.width = width;
            }
            public double Area()
            {
                return length * width;
            }
        }
    }
}