using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Clasess;


namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog Broasca1 = new Frog(1, "B1", "female");
            Frog Broasca2 = new Frog(2, "B2", "female");
            Frog Broasca3 = new Frog(3, "B3", "male");
            Frog Broasca4 = new Frog(2, "B4", "female");
            Frog[] Broaste = new[] { Broasca1, Broasca2, Broasca3, Broasca4 };

            Dog Caine1 = new Dog(4, "C1", "male");
            Dog Caine2 = new Dog(1, "C2", "male");
            Dog Caine3 = new Dog(10, "C3", "female");
            Dog Caine4 = new Dog(7, "C4", "female");
            Dog[] Caini = new[] { Caine1, Caine2, Caine3, Caine4 };

            Kitten Pisica1 = new Kitten(2, "P1", "female"); // e corect?
            Kitten Pisica2 = new Kitten(6, "P2", "female");
            Kitten Pisica3 = new Kitten(5, "P3", "female");
            Kitten Pisica4 = new Kitten(1, "P4", "female");
            Tomcat Motan1 = new Tomcat(5, "M1", "male");
            Tomcat Motan2 = new Tomcat(5, "M2", "male");
            Tomcat Motan3 = new Tomcat(7, "M3", "male");
            Tomcat Motan4 = new Tomcat(6, "M4", "male");
            Cat[] Pisici = new Cat[] { Motan1, Motan2, Motan3, Motan4, Pisica1, Pisica2, Pisica3, Pisica4 };

            AverageAgeOfAnimals.PrintBroasteAvaregeAge(Broaste);
            AverageAgeOfAnimals.PrintDogAvaregeAge(Caini);
            AverageAgeOfAnimals.PrintKittenAvaregeAge(Pisici);
            AverageAgeOfAnimals.PrintTomcatAvaregeAge(Pisici);


            Console.WriteLine("55");
            Console.ReadKey();
        }
    }
}
