using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_acasa_16._05.Interfaces; // favem nevoie de interfata IComments din namaspece Interfaces

namespace Tema_acasa_16._05.Classes
{
    public class Student : Human, IComments
    {
        private static int LastClassNo = 0;
        Student(string Name) // am creat un constructor cu parametrii pt a initializa Students
        {
            this.Name = Name;
            ClassNo = ++LastClassNo; // se autoincrementeaza LastClassNo
        }
        public int ClassNo { get; set; }

        public string Comments { get; set; }

        
    }
}
