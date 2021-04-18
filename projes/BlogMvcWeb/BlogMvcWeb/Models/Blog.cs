using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcWeb.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
        public string icerik { get; set; }
        public DateTime ekleme_tarihi { get; set; }
        public bool onay { get; set; }
        public bool anasayfa { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}