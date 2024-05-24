using System;
using System.Globalization;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using ConsoleApp15;
using System.Runtime.Serialization;

namespace ConsoleApp15
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser", 45, 25);

            //this get error in my system
            /* // Serialize the object data to a file
             Stream stream = File.Open("AnimalData.dat", FileMode.Create);
             BinaryFormatter bf = new BinaryFormatter();

             // Send the object data to the file
             bf.Serialize(stream, bowser);
             stream.Close();

             // Delete the bowser data
             bowser = null;

             // Read object data from the file
             stream = File.Open("AnimalData.dat", FileMode.Open);
             BinaryFormatter binaryFormatter = new BinaryFormatter();
             bf = binaryFormatter;

             bowser = (Animal)bf.Deserialize(stream);
             stream.Close();

             Console.WriteLine(bowser.ToString());
 */
            // Serialize the object data to a file using DataContractSerializer
            DataContractSerializer dcs = new DataContractSerializer(typeof(Animal));
            using (FileStream stream = File.Open("AnimalData.dat", FileMode.Create))
            {
                dcs.WriteObject(stream, bowser);
            }

            // Delete the bowser data
            bowser = null;

            // Read object data from the file
            using (FileStream stream = File.Open("AnimalData.dat", FileMode.Open))
            {
                dcs = new DataContractSerializer(typeof(Animal));
                bowser = (Animal)dcs.ReadObject(stream);
            }

            Console.WriteLine(bowser.ToString());

            // Change bowser to show changes were made
            bowser.Weight = 50;

            // XmlSerializer writes object data as XML
           
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\patel\C#Data\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }

            // Delete bowser data
            bowser = null;

            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\patel\C#Data\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();

            Console.WriteLine(bowser.ToString());

            // Save a collection of Animals
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60, 30),
                new Animal("Luigi", 55, 24),
                new Animal("Peach", 40, 20)
            };

            using (Stream fs = new FileStream(@"C:\Users\patel\C#Data\animals.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            // Delete list data
            theAnimals = null;

            // Read data from XML
            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\patel\C#Data\animals.xml"))
            {
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }


            foreach (Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();

        }
    }
}