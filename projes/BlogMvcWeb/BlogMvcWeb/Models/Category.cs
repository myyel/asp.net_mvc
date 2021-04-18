using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string kategori_adi { get; set; }

        public List<Blog> bloglar { get; set; }
    }
}