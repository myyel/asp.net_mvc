﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kategori
    {
        public int Id { get; set; }
        public string kategori_adi { get; set; }

        public List<Urun> urunler { get; set; }
    }
}
