using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo dereksDir = new DirectoryInfo(@"C:\Users\patel");
            Console.WriteLine(dereksDir.FullName);
            Console.WriteLine(dereksDir.Name);
            Console.WriteLine(dereksDir.Parent);
            Console.WriteLine(dereksDir.Attributes);
            Console.WriteLine(dereksDir.CreationTime);

            // Create a directory
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\patel\C#Data");
            dataDir.Create();
            // Delete a directory
            /*Directory.Delete(@"C:\Users\patel\C#Data");*/

            // ----- SIMPLE FILE READING & WRITING -----

            // Write a string array to a text file
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = @"C:\Users\patel\C#Data\testfile1.txt";
            ;
            // Write the array
            File.WriteAllLines(textFilePath,
                customers);

            // Read strings from array
            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            // ----- GETTING FILE DATA -----

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\patel\C#Data");

            // Get all txt files 
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt",
                SearchOption.AllDirectories);
            Console.WriteLine("Matches : {0}",
                txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                // Get file name
                Console.WriteLine(file.Name);

                // Get bytes in file
                Console.WriteLine(file.Length);
            }

            // ----- FILESTREAMS -----
            // FileStream is used to read and write a byte
            // or an array of bytes. 

            string textFilePath2 = @"C:\Users\patel\C#Data\testfile2.txt";

            // Create and open a file
            FileStream fs = File.Open(textFilePath2,
                FileMode.Create);

            string randString = "This is a random string";

            // Convert to a byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            // Write to file by defining the byte array,
            // the index to start writing from and length
            fs.Write(rsByteArray, 0,
                rsByteArray.Length);

            // Move back to the beginning of the file
            fs.Position = 0;

            // Create byte array to hold file data
            byte[] fileByteArray = new byte[rsByteArray.Length];

            // Put bytes in array
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            // Convert from bytes to string and output
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            // Close the FileStream
            fs.Close();


            // ----- STREAMWRITER / STREAMREADER -----
            // These are best for reading and writing strings

            string textFilePath3 = @"C:\Users\patel\C#Data\testfile3.txt";

            // Create a text file
            StreamWriter sw = File.CreateText(textFilePath3);
            sw.Write("This is a random ");
            sw.WriteLine("sentence.");
            sw.WriteLine("This is another sentence.");

            sw.Close();

            // Open the file for reading
            StreamReader sr = File.OpenText(textFilePath3);

            // Peek returns the next character as a unicode
            // number. Use Convert to change to a character
            Console.WriteLine("Peek : {0}",
                Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String : {0}",
                sr.ReadLine());

            // Read to the end of the file starting
            // where you left off reading
            Console.WriteLine("Everything : {0}",
                sr.ReadToEnd());

            sr.Close();

            // ----- BINARYWRITER / BINARYREADER -----
            // Used to read and write data types 
            string textFilePath4 = @"C:\Users\patel\C#Data\testfile4.dat";

            // Get the file
            FileInfo datFile = new FileInfo(textFilePath4);

            // Open the file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            // Data to save to the file
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            // Open file for reading
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();

        }
    }
}

