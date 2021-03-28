using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Urun
    {
        public int Id { get; set; }
        public string urun_adi { get; set; }
        public double fiyat { get; set; }
        public int stok_adeti { get; set; }
        public bool satista { get; set; }
    }
}
