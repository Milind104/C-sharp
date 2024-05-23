using ConsoleApp12;
using System.Collections;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsolApp12
{
    public class Program 
    {
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            var gt20=from num in nums
                     where num > 20
                     orderby num
                     select num;
            foreach(int num in gt20)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine($"Get Type:{gt20.GetType()}");

            //convert it into list or array
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            return arrayGT20;
        }
        static void Main(string[] args)
        {
            /*string[] dogs = {"K 9", "Brian Griffin",
            "Scooby Doo", "Old Yeller",
            "Benji", "Charlie B. Barkin", "Lassie",
            "Snoopy"};

            var dogSpaces=from dog in dogs
                          where dog.Contains(" ")
                          orderby dog descending
                          select dog;
            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }*/

            /*int[] intArray = QueryIntArray();

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }*/

            /*ArrayList: A non-generic collection that can store objects of any type. Using ArrayList requires careful handling of type casting. so use this is better 
             List<Animal> famAnimals = new List<Animal>()*/
            /*ArrayList famAnimals = new ArrayList()
            {
                new Animal{
                    Name = "Heidi",
                    Height = .8,
                    Weight = 18
                },

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };
            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var animal in smAnimals)
            {
                Console.WriteLine("{0} weighs {1}lbs",
                    animal.Name, animal.Weight);
            }*/
            Animal[] animals = new[]
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                AnimalID = 2},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks",
                OwnerID = 1},
                new Owner{Name = "Sally Smith",
                OwnerID = 2},
                new Owner{Name = "Paul Brooks",
                OwnerID = 3}
            };
            
            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height,
                            
                             };

            // Convert to an object array
            Array arrNameHeight = nameHeight.ToArray();

            /*foreach (var i in arrNameHeight)
            {
                Console.WriteLine(i.ToString());
            }*/

            // Create an inner join
            
            var innerJoin =
               from animal in animals
               join owner in owners on animal.AnimalID
               equals owner.OwnerID
               select new { OwnerName = owner.Name, AnimalName = animal.Name };

            foreach (var i in innerJoin)
            {
                Console.WriteLine("{0} owns {1}",
                    i.OwnerName, i.AnimalName);
            }

            Console.WriteLine();

            // Create a group inner join
            // Get all animals and put them in a
            // newly created owner group if their
            // IDs match the owners ID
            var groupJoin =
                from owner in owners
                orderby owner.OwnerID
                join animal in animals on owner.OwnerID
                equals animal.AnimalID into ownerGroup
                select new
                {
                    Owner = owner.Name,
                    Animals = from owner2 in ownerGroup
                              orderby owner2.Name
                              select owner2
                };

            int totalAnimals = 0;

            foreach (var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach (var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }
        }
    
    
    }

}
