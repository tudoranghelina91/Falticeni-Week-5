using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantsomeWeek5.Clasess
{
    public class Dog : Animal
    {
        public Dog(double age, string name, string sex) : base(age, name, sex)
        {

        }
        public override void SoundProduced()
        {
            Console.WriteLine("Hau! Hau!");
        }
    }
}
