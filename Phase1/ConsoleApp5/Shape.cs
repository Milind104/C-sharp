using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp5
{
    abstract class Shape
    {
        public string Name { get; set; }

        // You can define non-abstract methods in an abstract class
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        public abstract double Area();

    }
}