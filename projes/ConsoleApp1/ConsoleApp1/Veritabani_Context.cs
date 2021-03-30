using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Veritabani_Context:DbContext 
    {
        public Veritabani_Context():base("VeritabaniConnection")
        {
            Database.SetInitializer(new VeriInitializer());
        }

        public DbSet<Kategori> kategoriler { get; set; }
        public DbSet<Urun> urunler { get; set; }
    }
}
