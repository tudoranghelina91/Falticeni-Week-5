using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Clasess
{
    public class Kitten : Cat
    {
        public Kitten (double age, string name, string sex) : base(age, name, sex)
        {
            this.Sex = "Female";
        }
    }
}
