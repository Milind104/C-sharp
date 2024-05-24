using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Text;
using System.Globalization;

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

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                // We are throwing an exception because
                // you can't divide by zero
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        static double GetSum(double x=1, double y = 1) 
        {
            double temp = x;
            x = y;
            y= temp;
            return x + y;
        }

        // ----- OUT PARAMETER -----
        // A parameter marked with out must be assigned a value in the method
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // ----- PASS BY REFERENCE -----
       
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // ----- PARAMS -----
        // The params array must be the last parameter  in the list
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // ----- NAMED PARAMETERS -----
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        // ----- METHOD OVERLOADING -----
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }


        // ---- END OF FUNCTIONS --------

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }
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



            /*// ------ ARRAYS ------
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

            for (int k = 0; k < randomArray.Length; k++)
            {
               
                Console.WriteLine("Array {0} : Value : {1}" , k, randomArray[k]);
            }

            //------Multidimensional arrays----

            string[,] custName = new string[2, 2] { { "Milind", "krunal" }, 
                { "poorav", "gaurang" } };
            Console.WriteLine("MD vlaue:{0}", custName[1,1]);
            Console.WriteLine("Md vlaue:{0}", custName.GetValue(1, 1));
            
            //using for loop 

            for(int j = 0;j < custName.GetLength(0);j++)
            {
                for(int k = 0;k < custName.GetLength(1);k++)
                {
                    Console.WriteLine("{0}",custName[j, k]);
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
            }*/

            /* // ----- If - else   -----


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
             bool canDrive = age >= 16 ? true : false;*/





            /*// -------- Switch -----------
            
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
            Console.WriteLine("Elementary, Middle, High School");*/


            /*// ----- WHILE LOOP -----
           
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
            }*/

            /*// ----- DO WHILE LOOP -----
            // Use do while when you must execute the code
            // at least once

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

            Console.WriteLine("You guessed it is was {0}",secretNumber);*/


            /*// ----- EXCEPTION HANDLING -----
            // We use exception handling to catch errors
            // that could crash our program
            double num1 = 5;
            double num2 = 0;

            // Code that could cause an error is surrounded
            // by a try block
            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }

            // We catch the error and warn the user
            // rather then crash the program
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't Divide by Zero");

                // Get additonal info on the exception
                Console.WriteLine("Exception Type: " + ex.GetType().Name);
                Console.WriteLine("Message: " + ex.Message);

            }

            // This is the default catch all for exceptions
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine("Exception Type: " + ex.GetType().Name);
                Console.WriteLine("Message: " + ex.Message);
            }

            // finally always runs and provides for clean up
            finally
            {
                Console.WriteLine("Cleaning Up");
            }

           // Try Block: Executes code that might throw an exception.

           //Catch Blocks: Handle specific exceptions.
                            //The first catch handles DivideByZeroException,
                           //while the second is a general handler for any other exceptions.

           //Finally Block: Executes cleanup code that runs whether or not an exception occurred.*/


            /*// -----STRINGBUILDER---- -
            // Each time you change a string you are actually
            // creating a new string which is inefficient
            // when you are working with large blocks of text
            // StringBuilders actually change the text
            // rather then make a copy

            // Create a StringBuilder with a default size
            // of 16 characters, but it grows automatically
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
           // Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            //Console.WriteLine("Length : {0}", sb2.Length);

            // Add text to StringBuilder
            sb2.AppendLine(" \nMore important text");

            

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append a format string
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            // Output StringBuilder
            Console.WriteLine(sb2.ToString());
            Console.WriteLine("-----------------------------");

            // Replace a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            //create variables with different data types in C#
           //and convert them to strings using the ToString() method.

            // Clear a string builder
            sb2.Clear();

            sb2.Append("Random Text");

            // Are objects equal
            Console.WriteLine(sb.Equals(sb2));

            // Insert at an index
            sb2.Insert(11, " that's Great");

            Console.WriteLine("Insert : {0}", sb2.ToString());

            // Remove number of characters starting at index
            sb2.Remove(11, 7);

            Console.WriteLine("Remove : {0}", sb2.ToString());*/

            // ---------- FUNCTIONS / METHODS ----------
            SayHello();

            double x = 5;
            double y = 4;
            Console.WriteLine("5+4 ={0}",GetSum(x, y));
            Console.WriteLine("x : {0}", x);

           
            int solution;
            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}",
                solution);

            // ----- PASS BY REFERENCE -----
            int num3 = 10;
            int num4 = 20;

            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num3, num4);

            Swap(ref num3, ref num4);

            //Console.WriteLine("After Swap num1 : {0} num2 : {1}", num1, num2);

        
            Console.WriteLine("1 + 2 + 3 = {0}",
                GetSumMore(1, 2, 3));

            
            // You can pass values in any order if you used named parameters
            PrintInfo(zipCode: 15147,
                name: "Derek Banas");

            // ----- METHOD OVERLOADING -----
            // You can define methods with the same
            // name that will be called depending on
            // what data is sent automatically
            Console.WriteLine("5.0 + 4.0 = {0}",
                GetSum2(5.0, 4.5));

            Console.WriteLine("5 + 4 = {0}",
                GetSum2(5, 4));

            Console.WriteLine("5 + 4 = {0}",
                GetSum2("5", "4"));


            // ---------- DATETIME & TIMESPAN ----------

            // Used to define dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            // You can change values
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            // TimeSpan
            // Used to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // Change values
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            // ----- ENUM -----
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

            // Waits for input from the user if you run the
            // ConsoleApp1.exe instead of instantly closing
            // The executable is in bin/Debug/net6.0
            Console.Read();


        }
    }
}