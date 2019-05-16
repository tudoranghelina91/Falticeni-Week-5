using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_acasa_16._05.Interfaces;

namespace Tema_acasa_16._05.Classes
{
    class SchoolClass:IComments
    {
        public string TextId { get; set; }
        public string Comments { get; set; }
        List<Teacher> Profi = new List<Teacher>();
    }
}
