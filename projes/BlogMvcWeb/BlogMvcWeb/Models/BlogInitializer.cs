using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcWeb.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {   
                new Category(){kategori_adi="C#"},
                new Category(){kategori_adi="Asp.net MVC"},
                new Category(){kategori_adi="Asp.net WebForm"},
                new Category(){kategori_adi="Windows Form"}
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog()
                    {
                        baslik="C# Console",
                        aciklama="C# Console hakkında",
                        resim="1.jpg",
                        icerik="C# Console Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-10),
                        onay=true,
                        anasayfa=true,
                        CategoryId=1
                    },
                new Blog()
                    {
                        baslik="C# Form",
                        aciklama="C# Form hakkında",
                        resim="2.jpg",
                        icerik="C# Form Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-5),
                        onay=true,
                        anasayfa=true,
                        CategoryId=1
                    },
                new Blog()
                    {
                        baslik="C# Web",
                        aciklama="C# Web hakkında",
                        resim="3.jpg",
                        icerik="C# web Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-15),
                        onay=true,
                        anasayfa=false,
                        CategoryId=1
                    },
                new Blog()
                    {
                        baslik="C++ Console",
                        aciklama="C++ Console hakkında",
                        resim="4.jpg",
                        icerik="C++ Console Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-10),
                        onay=true,
                        anasayfa=true,
                        CategoryId=2
                    },
                new Blog()
                    {
                        baslik="C++ Form",
                        aciklama="C++ Form hakkında",
                        resim="5.jpg",
                        icerik="C++ Form Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-5),
                        onay=true,
                        anasayfa=false,
                        CategoryId=2
                    },
                new Blog()
                    {
                        baslik="C++ Web",
                        aciklama="C++ Web hakkında",
                        resim="6.jpg",
                        icerik="C++ web Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-15),
                        onay=false,
                        anasayfa=false,
                        CategoryId=2
                    },
                new Blog()
                    {
                        baslik="Python Console",
                        aciklama="Python Console hakkında",
                        resim="7.jpg",
                        icerik="Python Console Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-10),
                        onay=true,
                        anasayfa=true,
                        CategoryId=3
                    },
                new Blog()
                    {
                        baslik="Python Form",
                        aciklama="Python Form hakkında",
                        resim="8.jpg",
                        icerik="Python Form Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-5),
                        onay=true,
                        anasayfa=false,
                        CategoryId=3
                    },
                new Blog()
                    {
                        baslik="Python Web",
                        aciklama="Python Web hakkında",
                        resim="9.jpg",
                        icerik="Python web Hakkında her şey",
                        ekleme_tarihi=DateTime.Now.AddDays(-15),
                        onay=false,
                        anasayfa=false,
                        CategoryId=3
                    }
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}