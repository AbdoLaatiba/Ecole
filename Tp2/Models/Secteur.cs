using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tp2.Models
{
    public class Secteur
    {
        [Key]
        public int codeSecteur { get; set; }
        public string nomSecteur { get; set; }
    }
}
