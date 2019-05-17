using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AnimalHierarchy.Clasess
{
    public class Frog : Animal
    {
        public Frog(double age, string name, string sex) : base (age, name, sex)
        {

        }
        public override void SoundProduced()
        {
            Console.WriteLine("Oac! Oac!");
        }
        
    }
}
