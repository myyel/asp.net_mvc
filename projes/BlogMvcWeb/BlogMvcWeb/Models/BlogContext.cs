using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcWeb.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext()
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}