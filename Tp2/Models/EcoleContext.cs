using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Tp2.Models
{
    public class EcoleContext : DbContext
    {
        public EcoleContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Module> modules { get; set; }
        public DbSet<Filiere> filieres { get; set; }
        public DbSet<Groupe> groupes { get; set; }
        public DbSet<Secteur> secteurs { get; set; }
    }
}
