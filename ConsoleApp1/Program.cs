using System;
using System.Drawing;

namespace ConsoleApp1
{
    public class Program
    {
        // ------- FUNCTIONS ----------

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}",mess,i);
            }
        }
        // ---- END OF FUNCTIONS --------
        static void Main(string[] args)
        {
            /*
         
            //----------Console Methods----------
            
             Console.ForegroundColor = ConsoleColor.Green;
             Console.BackgroundColor = ConsoleColor.White;
             Console.Clear();
             Console.WriteLine("Hello World");
             Console.Write("What is your name? ");
             string name = Console.ReadLine();
             Console.WriteLine($"Hello {name}");

            */



            /*
             
            // ------ VARIABLES ------
           
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


            /*
             
            // ---------- DATA TYPE CONVERSION ----------
            
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

            /*// ---------- FORMATTING OUTPUT ----------


            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Commas : {0:n4}", 2300);*/


            /*
             // ---------- STRINGS ----------
            // Strings store a series of characters
            string randString = "This is a string";
            //******String Formatting with Placeholders*******

            //In C#, you can use placeholders in a format string to insert values dynamically at runtime.
            //The placeholders are enclosed in curly braces {} and are indexed starting from 0.
            //The index inside the curly braces corresponds to the position of the argument in the parameter list.

            //Example Explained
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));
            
            // "String Contains is : {0}" is the format string.
            // {0} is the placeholder that will be replaced by the first argument after the format string, which is randString.Contains("is") in this case.
            // randString.Contains("is") evaluates to True or False depending on whether the substring "is" is found in randString.
            // When randString is "This is a string", the expression randString.Contains("is") returns True, 
  
            //so the output will be:String Contains is : True
            */


            /*
            // ---------- STRINGS ----------
            // Strings store a series of characters
            string randString = "This is a string";
            Console.WriteLine("String Length : {0}", randString.Length);


            The Contains method checks if a specified substring exists within the string.
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
            */



            // ------ ARRAYS ------
            //Arrays are used to store multiple values in a single variable,
            //instead of declaring separate variables for each value.

            //create a array of size 3
            int[] favNums = new int[3];

            //add value to the arrary
            favNums[0] = 26;
            favNums[1] = 27;
            favNums[2] = 28;
            Console.WriteLine("favNum at index 0: {0} \n " +
                "favNum at index 1:{1} \n " +
                "favNum at index 2:{2}",
                favNums[0], favNums[1], favNums[2]);

            //craete and fill array
            string[] customers = { "poorav", "milind", "krunal", "gaurang" };
            Console.WriteLine(customers[1]);

            //you can use var to create array but the values must be same type
            var employees = new[] { "poorav", "milind", "krunal", "gaurang" };
            Console.WriteLine(employees[0]);
      

            //create a array of base objects which is the 
            //base type of all other types
            object[] randomArray = { "Milind", 18, 3.14 };
            Console.WriteLine(randomArray[0]);
            Console.WriteLine(randomArray[1]);
            Console.WriteLine(randomArray[2]);


            // GetType knows its true type
         
            Console.WriteLine("random array 0:{0}  1:{1}", randomArray[0].GetType(), randomArray[1].GetType());

            Console.WriteLine("random array 2:{0}", randomArray[2].GetType());

            // Get number of items in array
            Console.WriteLine("Array Size : {0}",randomArray.Length);


            // ------for loop ----------
            Console.WriteLine("\nFor Loop\n");

            for (int i = 0; i < randomArray.Length; i++)
            {
               
                Console.WriteLine("Array {0} : Value : {1}" , i, randomArray[i]);
            }

            //------Multidimensional arrays----

            string[,] custName = new string[2, 2] { { "Milind", "krunal" }, 
                { "poorav", "gaurang" } };
            Console.WriteLine("MD vlaue:{0}", custName[1,1]);
            Console.WriteLine("Md vlaue:{0}", custName.GetValue(1, 1));
            
            //using for loop 

            for(int i = 0;i < custName.GetLength(0);i++)
            {
                for(int j = 0;j < custName.GetLength(1);j++)
                {
                    Console.WriteLine("{0}",custName[i, j]);
                }
                Console.WriteLine();
            }


            // functions
            int[] randNums = { 1, 4, 9, 2 };

            PrintArray(randNums, "FoeeachLoop");

            Console.WriteLine("------sort array-----------");
            Array.Sort(randNums);
            PrintArray(randNums, "sortArray");


            Console.WriteLine("------reverse array-----------");
            Array.Reverse(randNums);
            PrintArray(randNums, "ReverseArray");

            Console.WriteLine("------index of  array-----------");
            Console.WriteLine("1 at index : {0} ",
                Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);
            PrintArray(randNums, "change value at index");

            // Copy part of an array to another
            int[] srcArray = { 5, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray,
                startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 11);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

            // ----- If - else   -----
            

            int age = 10;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }

            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }

            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }

            else
            {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));



           //terneary operator
            bool canDrive = age >= 16 ? true : false;





            // -------- Switch -----------
            
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");


            // ----- WHILE LOOP -----
           
            int i = 1;
            while (i <= 10)
            {
               
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 9) break;

                Console.WriteLine(i);
                i++;
            }

            // ----- DO WHILE LOOP -----
            // Use do while when you must execute the code at least once

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : ", secretNumber);

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");

                // Use Convert to switch the string into an int
                // Other Convert options : ToBoolean, ToByte,
                // ToChar, ToDecimal, ToDouble, ToInt64,
                // ToString, and they can convert from any
                // type to any other type
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it is was {0}",
                secretNumber);


        }
    }
}