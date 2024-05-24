using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp10
{
    

    class Program 
    {
        delegate double doubleIt(double val);
        
        static void Main(string[] args)
        {
            doubleIt dblIt = y => y * 2;
            Console.WriteLine($"5 * 2 ={dblIt(5) }"); // This is a lamda expers..

            Console.WriteLine( "-------------");
            //find all even nunmber
            List<int> numList = new List<int> { 1,9,2,6,3};
            var evenList=numList.Where(a => a%2==0).ToList();
            Console.WriteLine("even list:");
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("-----");
            Console.WriteLine("Add values in a range to a list");
            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();

            foreach (var k in rangeList)
                Console.WriteLine(k);

            // Find the number of heads and tails in a list 1 = H, 2 = T
            Console.WriteLine("----------");

            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3)); // Generates a random integer between 1 and 2 
                i++;
            }

            Console.WriteLine("Heads : {0}",
                flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}",
                flipList.Where(a => a == 2).ToList().Count());

            Console.WriteLine("Find all names starting with s");
            var nameList = new List<string> { "Doug", "Sally", "Sue","cat" };

            var sNameList = nameList.Where(x => x.StartsWith("S"));

            foreach (var m in sNameList)
                Console.WriteLine(m);


            // ---------- SELECT ----------
            Console.WriteLine("---------- SELECT ----------");           
            // Select allows us to execute a function  on each item in a list

            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            //Enumerable.Range(1, 10): Generates a sequence of integers starting at 1 and containing 10 elements (i.e., 1, 2, 3, ..., 10).

            var squares = oneTo10.Select(x => x * x);

            foreach (var l in squares)
                Console.WriteLine(l);

            // ---------- ZIP ----------
            Console.WriteLine("---------- ZIP ----------");
            // Zip applies a function to two lists 
            // Add values in 2 lists together
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });

            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var n in sumList)
                Console.WriteLine(n);

            // ---------- AGGREGATE ----------
            Console.WriteLine("---------- AGGREGATE ----------");
            // Aggregate performs an operation on 
            // each item in a list and carries the 
            // results forward 

            // Sum values in a list
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum : {0}",
                numList2.Aggregate((a, b) => a + b));

            // ---------- AVERAGE ----------
            Console.WriteLine("---------- AVERAGE ----------");
            // Get the average of a list of values
            var numList3 = new List<int>() { 1, 2, 3, 4, 5 };

            // AsQueryable allows you to manipulate the
            // collection with the Average function
            Console.WriteLine("AVG : {0}",
                numList3.AsQueryable().Average());

            // ---------- ALL ----------
            Console.WriteLine("---------- ALL ----------");
            // Determines if all items in a list
            // meet a condition
            var numList4 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("All > 3 : {0}",
                numList4.All(x => x > 3));

            // ---------- ANY ----------
            Console.WriteLine("---------- ANY ----------");
            // Determines if any items in a list
            // meet a condition
            var numList5 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Any > 3 : {0}",
                numList5.Any(x => x > 3));

            // ---------- DISTINCT ----------
            Console.WriteLine("---------- DISTINCT ----------");
            // Eliminates duplicates from a list
            var numList6 = new List<int>() { 1, 2, 3, 2, 3 };

            Console.WriteLine("Distinct : {0}",
                string.Join(", ", numList6.Distinct()));

            // ---------- EXCEPT ----------
            Console.WriteLine("---------- EXCEPT ----------");
            // Receives 2 lists and returns values not
            // found in the 2nd list
            var numList7 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList8 = new List<int>() { 3 };

            Console.WriteLine("Except : {0}",
                string.Join(", ", numList7.Except(numList8)));

            // ---------- INTERSECT ----------
            Console.WriteLine("---------- INTERSECT ----------");
            // Receives 2 lists and returns values that
            // both lists have
            var numList9 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList10 = new List<int>() { 2, 3 };

            Console.WriteLine("Intersect : {0}",
                string.Join(", ", numList9.Intersect(numList10)));


        }



    }

}