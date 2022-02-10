using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOdev
{
    class Matematik
    {
        //Topla
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        //Cikart
        public decimal cikartmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //Bölme İşlemi
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        //Carpma İşlemi
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("*** Menü *** ");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkartma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.Write("Lütfen bir değer seçiniz: ");
        }

        public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", kullaniciSayi1, operators, kullaniciSayi2, sonuc);
        }


    }
}
