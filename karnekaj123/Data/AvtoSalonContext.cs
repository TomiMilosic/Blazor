using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace karnekaj123.Data
{
    public class AvtoSalonContext : DbContext
    {
        public DbSet<Avto> Avtos { get; set; }
        public DbSet<AvtoSalon> salons { get; set; }
        public DbSet<Vmesna> vmesnas { get; set; }
    }
}
