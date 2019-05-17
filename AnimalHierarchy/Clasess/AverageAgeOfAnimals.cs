using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Clasess
{
    public static class AverageAgeOfAnimals
    {
        public static void PrintBroasteAvaregeAge(Frog[] Broaste)
        {
            double sumAge = 0;
            double nrOfAnimals = 0;
            foreach (Frog animal in Broaste)
            {
                sumAge += animal.Age;
                nrOfAnimals++;
            }
            Console.WriteLine("Varsta medie a broastelor este {0}:", sumAge / nrOfAnimals);
        }
        public static void PrintDogAvaregeAge(Dog[] Caini)
        {
            double sumAge = 0;
            double nrOfAnimals = 0;
            foreach (Dog animal in Caini)
            {
                sumAge += animal.Age;
                nrOfAnimals++;
            }
            Console.WriteLine("Varsta medie a cainilor este {0}:", sumAge / nrOfAnimals);
        }

        public static void PrintKittenAvaregeAge(Cat[] Pisici)
        {
            double sumAge = 0;
            double nrOfAnimals = 0;
            foreach (Cat animal in Pisici)
            {
                if (animal is Kitten)
                {
                    sumAge += animal.Age;
                    nrOfAnimals++;
                }
            }
            Console.WriteLine("Varsta medie a pisicilor este {0}:", sumAge / nrOfAnimals);
        }
        public static void PrintTomcatAvaregeAge(Cat[] Pisici)
        {
            double sumAge = 0;
            double nrOfAnimals = 0;
            foreach (Cat animal in Pisici)
            {
                if (animal is Tomcat)
                {
                    sumAge += animal.Age;
                    nrOfAnimals++;
                }
            }
            Console.WriteLine("Varsta medie a motanilor este {0}:", sumAge / nrOfAnimals);
        }
    }
}
