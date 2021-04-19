using BlogMvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcWeb.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = db.Bloglar.Select(i => new BlogAnasayfa()
            {
                Id = i.Id,
                baslik = i.baslik.Length > 100 ? i.baslik.Substring(0, 100) + "..." : i.baslik,
                aciklama = i.aciklama,
                ekleme_tarihi = i.ekleme_tarihi,
                anasayfa = i.anasayfa,
                onay = i.onay,
                resim = i.resim
            }).Where(i => i.onay==true && i.anasayfa==true);


            return View(bloglar.ToList()) ;
        }
    }
}