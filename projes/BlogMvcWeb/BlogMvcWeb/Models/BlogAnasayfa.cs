using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcWeb.Models
{
    public class BlogAnasayfa
    {
        public int Id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
        public DateTime ekleme_tarihi { get; set; }
        public bool onay { get; set; }
        public bool anasayfa { get; set; }
    }
}