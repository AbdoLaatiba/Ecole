using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tp2.Models
{
    public class Module
    {
        [Key]
        public int codeM { get; set; }
        public string nomM { get; set; }
        public string MassH { get; set; }
        public int codeF { get; set; }
        public Filiere filiere { get; set; }



    }
}
