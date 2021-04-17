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
            Veritabani_Context db = new Veritabani_Context();

            var urun = db.urunler.OrderBy(i => new { i.urun_adi, i.Id }).Take(6).ToList();

            foreach (var item in urun)
            {
                Console.WriteLine(item.urun_adi+" "+item.fiyat);
            }


            Console.ReadLine(); 
        }
    }
}
    