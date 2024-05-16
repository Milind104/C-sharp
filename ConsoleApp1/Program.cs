using System;
using System.Drawing;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //----------Console Methods----------
            /*
             Console.ForegroundColor = ConsoleColor.Green;
             Console.BackgroundColor = ConsoleColor.White;
             Console.Clear();
             Console.WriteLine("Hello World");

             Console.Write("What is your name? ");
             string name = Console.ReadLine();
             Console.WriteLine($"Hello {name}");
            */


            // ------ VARIABLES ------
            /*
            // Variables are containers for storing data values.

            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            //Note that you should end the value with an "L":
            long myNum = 15000000000L;
            Console.WriteLine(myNum);
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // DECIMALS
            // Decimals store 128-bit precise decimal values
            // It is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);

            //The float and double data types can store fractional numbers.
            //Note that you should end the value with an "F" for floats and "D" for doubles:
            float myNum1 = 5.75F;
            Console.WriteLine(myNum1);

            double myNum2 = 19.99D;
            Console.WriteLine(myNum2);

            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double : {0}", Double.MaxValue);

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            //Scientific Numbers
            //A floating point number can also be a scientific number with an "e" to indicate the power of 10
            */


            // ---------- DATA TYPE CONVERSION ----------
            /*
            // You can convert from string to other types with Parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            // Convert double into a string
            string strVal = dblFromStr.ToString();

            // Get the new data type
            Console.WriteLine($"Data type : {strVal.GetType()}");

            // Cast double into integer (Explicit Conversion)
            // Put the data type to convert into between ()
            //Explicit casting can lead to data loss if the target type cannot represent the value accurately
            //(e.g., converting a double with a fractional part to an integer).


            double dblNum = 12.345;
            Console.WriteLine($"Integer : {(int)dblNum}");

            // Cast integer into long (Implicit Conversion)
            //Implicit conversions are safe and do not result in data loss.
            // smaller size type --> larger size
            int intNum = 10;
            long longNum = intNum;
            */

            // ---------- FORMATTING OUTPUT ----------

            /*
             Console.WriteLine("Currency : {0:c}", 23.455);
             Console.WriteLine("Pad with 0s : {0:d4}", 23);
             Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
             Console.WriteLine("Commas : {0:n4}", 2300);
             */

            // ---------- STRINGS ----------
            // Strings store a series of characters
            string randString = "This is a string";
            //******String Formatting with Placeholders*******

            //In C#, you can use placeholders in a format string to insert values dynamically at runtime.
            //The placeholders are enclosed in curly braces {} and are indexed starting from 0.
            //The index inside the curly braces corresponds to the position of the argument in the parameter list.

            //Example Explained
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));
            /*
             "String Contains is : {0}" is the format string.
             {0} is the placeholder that will be replaced by the first argument after the format string, which is randString.Contains("is") in this case.
             randString.Contains("is") evaluates to True or False depending on whether the substring "is" is found in randString.
             When randString is "This is a string", the expression randString.Contains("is") returns True, 
            
            so the output will be:String Contains is : True
             */


          
            

            
            Console.WriteLine("String Length : {0}", randString.Length);


            //The Contains method checks if a specified substring exists within the string.
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));

           
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));

            // Remove number of characters starting at an index
            Console.WriteLine("Remove string : {0}",
                randString.Remove(10, 6));

            // Add a string starting at an index
            Console.WriteLine("Insert String : {0}",
                randString.Insert(10, "short "));

            // Replace a string 
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));

          

            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            // Check if strings are equal
            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // Add padding left
            Console.WriteLine("Pad Left : {0} ",
                randString.PadLeft(20, '.'));

            // Add padding right
            Console.WriteLine("Pad Right : {0} HIIIIIII",
                randString.PadRight(20, '.'));

            // Trim whitespace
            Console.WriteLine("Trim : {0}",
                randString.Trim());

            //  uppercase
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());

            // lowercase
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());

            // Use Format to create strings
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");

            //  add newlines with \n and join strings with +
            Console.Write(newString + "\n");

            Console.WriteLine(@"Exactly What I Typed\n");



        }
    }
}