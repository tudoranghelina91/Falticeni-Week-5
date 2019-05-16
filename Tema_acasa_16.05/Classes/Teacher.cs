using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_acasa_16._05.Interfaces;

namespace Tema_acasa_16._05.Classes
{
    class Teacher:Human, IComments
    {
        public string Comments { get; set; }
        List<Disciplines> Materie = new List<Disciplines>();

    }

}
