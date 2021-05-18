using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tp2.Models
{
    public class Groupe
    {
        [Key]
        public int codeG { get; set; }
        public string nomG { get; set; }
        public int CodeF { get; set; }
        public Filiere filiere { get; set; }

    }
}
