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
            Veritabani_Context yol = new Veritabani_Context();

            var urun = yol.urunler.Find(3);

            Console.WriteLine("ürünün adı={0} ürün fiyatı={1} stok adeti={2}", urun.urun_adi, urun.fiyat, urun.stok_adeti);

            urun.urun_adi = "Samsung S4";
            urun.fiyat = 3000;
            urun.stok_adeti = 100;

            yol.SaveChanges();

            urun = yol.urunler.Find(3);

            Console.WriteLine("ürünün adı={0} ürün fiyatı={1} stok adeti={2}", urun.urun_adi, urun.fiyat, urun.stok_adeti);

            Console.ReadLine();
        }
    }
}
