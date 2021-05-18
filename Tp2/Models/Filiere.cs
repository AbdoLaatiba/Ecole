using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tp2.Models
{
    public class Filiere
    {
        [Key]
        public int codeF { get; set; }
        public string nomF { get; set; }
        public int codeSecteur { get; set; }
        public Secteur secteur { get; set; }
        public ICollection<Groupe> groupes { get; set; }
        public ICollection<Module> modules { get; set; }
    }
}
