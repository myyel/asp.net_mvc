using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veritabani_Context veri = new Veritabani_Context();
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){urun_adi="samsung", fiyat=5000, stok_adeti=200, satista=true, KategoriId=1},
                new Urun(){urun_adi="iphone", fiyat=8000, stok_adeti=200, satista=false, KategoriId=1} 
            };

            Kategori kats = new Kategori();
            kats.kategori_adi = "telefon";

            veri.kategoriler.Add(kats);

            foreach (var item in urunler)
            {

                veri.urunler.Add(item);
            }
            veri.SaveChanges();

            Console.WriteLine("database created");

            Console.ReadLine();
        }
    }
}
