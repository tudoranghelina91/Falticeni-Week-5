using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_acasa_16._05.Interfaces;

namespace Tema_acasa_16._05.Classes
{
    public class Disciplines : IName, IComments
    {
        public string Name { get; set; }
        public string Comments { get; set; }
        public int NrOfLectures { get; set; }
        public int NrOfExercices { get; set; }
    }
}
