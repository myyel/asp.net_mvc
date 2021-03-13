using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class urun
    {
        public int urun_id { get; set; }
        public string urun_adi { get; set; }
        public string aciklama { get; set; }
        public int fiyat { get; set; }
        public bool satista_mi { get; set; }
    }
}