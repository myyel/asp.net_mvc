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

            List<kategori> kategoriler = new List<kategori>()
            {
                new kategori(){id=1, kategori_adi="telefon"},
                new kategori(){id=1, kategori_adi="tablet"},
                new kategori(){id=1, kategori_adi="bilgisayar"}
            };

            ViewBag.urun_sayisi = urunler.Count();
            ViewBag.kategoriler = kategoriler;

            return View(urunler);
        }

        public ActionResult Urun()
        {
            List<urun> urunler = new List<urun>()
            {
                new urun(){urun_id=9,urun_adi="İphone 5", fiyat=2000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=10,urun_adi="İphone 6", fiyat=3000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=11,urun_adi="İphone 7", fiyat=4000, aciklama="idare eder", satista_mi=false},
                new urun(){urun_id=12,urun_adi="İphone 8", fiyat=5000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=13,urun_adi="Samsung 5", fiyat=2000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=14,urun_adi="Samsung 6", fiyat=3000, aciklama="idare eder", satista_mi=true},
                new urun(){urun_id=15,urun_adi="Samsung 7", fiyat=4000, aciklama="idare eder", satista_mi=false},
                new urun(){urun_id=16,urun_adi="Samsung 8", fiyat=5000, aciklama="idare eder", satista_mi=true},
            };

            List<kategori> kategoriler = new List<kategori>()
            {
                new kategori(){id=2, kategori_adi="telefon"},
                new kategori(){id=2, kategori_adi="tablet"},
                new kategori(){id=2, kategori_adi="bilgisayar"}
            };

            urun_kategori model = new urun_kategori();
            model.urunler = urunler;
            model.kategoriler = kategoriler;
            ViewBag.urun_sayisi = urunler.Count();


            return View(model);
        }
    }
}