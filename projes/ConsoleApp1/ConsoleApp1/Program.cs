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

            var urunler = yol.urunler.Select(
                i => new
                {
                    urun_adi = i.urun_adi,
                    fiyat=i.fiyat,
                    kategori=i.Kategori.kategori_adi
                });
            foreach (var item in urunler)
            {

                Console.WriteLine("urun adı: {0}  fiyat: {1}  kategori: {2}", item.urun_adi, item.fiyat, item.kategori);
            }

            Console.ReadLine();
        }
    }
}
