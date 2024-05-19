using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public, private, protected, constants,
// read-only fields, constructors, setters, getters, 
// properties and more on static

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();

            cat.SetName("Whiskers");

            cat.Sound = "Meowww";

            Console.WriteLine("The cat is named {0} and says {1}",
                cat.GetName(), cat.Sound);

            cat.Owner = "Milind";

            Console.WriteLine("{0} owner is {1}",
                cat.GetName(), cat.Owner);

            Console.WriteLine("{0} shelter id is {1}",
                cat.GetName(), cat.idNum);

            Console.WriteLine("# of Animals : {0}",
                Animal.NumOfAnimals);


         

        }
    }
}