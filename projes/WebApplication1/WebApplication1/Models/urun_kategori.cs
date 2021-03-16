using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class urun_kategori
    {
        public List<urun> urunler { get; set; }
        public List<kategori> kategoriler { get; set; }
    }
}