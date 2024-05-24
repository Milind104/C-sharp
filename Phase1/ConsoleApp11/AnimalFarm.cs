using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    //IEnumerable provides for iteration over a collection
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalsList = new List<Animal>();
        private AnimalFarm(List<Animal> animalList) 
        {
            this.animalsList = animalList;
        }
        public AnimalFarm() { }

        //Indexer for Animalfarm created with this[]
        public Animal this[int index]
        {
            get { return (Animal)animalsList[index]; }
            set { animalsList.Insert(index, value); }
        }

        public int Count
        {
            get
            {
                return animalsList.Count;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return animalsList.GetEnumerator();
        }
    }
}
