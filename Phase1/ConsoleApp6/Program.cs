using ConsoleApp6;
using System;

// A class can support multiple interfaces. 

// Create an interface Project -> Add New Item
// and select Interface

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Vehicle object
            Vehicle swift = new Vehicle("swift",
                4, 160);

            // Check if Vehicle implements 
            // IDrivable
            if (swift is IDrivable)
            {
                swift.Move();
                swift.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", swift.Brand);
            }

            // We are now modeling the act of
            // picking up a remote, aiming it
            // at the TV, clicking the power
            // button and then watching as
            // the TV turns on and off

            // Pick up the TV remote
            IElectronicDevice TV = TVRemote.GetDevice();

            // Create the power button
            PowerButton powBut = new PowerButton(TV);

            // Turn the TV on and off with each 
            // press
            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();

        }

    }

}