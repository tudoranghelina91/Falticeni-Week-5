using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Clasess
{
    public abstract class Animal : ISound
    {
        public double Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Animal(double age, string name, string sex) // am facut constructor pt a reduce codul din clase si Program
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public abstract void SoundProduced();
    }
}
