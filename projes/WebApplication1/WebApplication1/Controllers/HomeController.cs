using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<urun> urunler = new List<urun>()
            {
                new urun(){urun_id=1,urun_adi="İphone 5", fiyat=2000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=2,urun_adi="İphone 6", fiyat=3000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=3,urun_adi="İphone 7", fiyat=4000, aciklama="idare eder", satista_mi=false},
                new urun(){urun_id=4,urun_adi="İphone 8", fiyat=5000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=5,urun_adi="Samsung 5", fiyat=2000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=6,urun_adi="Samsung 6", fiyat=3000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=7,urun_adi="Samsung 7", fiyat=4000, aciklama="idare eder", satista_mi=false},
                new urun(){urun_id=8,urun_adi="Samsung 8", fiyat=5000, aciklama="idare eder", satista_mi=true},
            };

            ViewBag.urun_sayisi = urunler.Count();

            return View(urunler);
        }
    }
}