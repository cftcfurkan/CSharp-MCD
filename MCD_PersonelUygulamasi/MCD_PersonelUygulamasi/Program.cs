using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
     class Program
    {
        public static object Helper { get; private set; }

        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "Faik";
            P1.Soyisim = "Turan";
            P1.Emailadres = "faik.turan";
            P1.Cinsiyet = 717770001;//Bay 717770002 - Bayan

            Personel P2 = new Personel();
            P2.Isim = "Ali";
            P2.Soyisim = "Gel";
            P2.Emailadres = "ali.gel";
            P2.Cinsiyet = 717770001;//Bay 717770002 - Bayan

            Console.WriteLine("ik@firmam.com Yeni Personel Bilgilendirme : {0} {1}",P1.Isim,P1.Soyisim);
            Console.WriteLine("ik@firmam.comYeni Personel Bilgilendirme: {0} {1}", P2.Isim,P2.Soyisim);

            Console.ReadKey();
        }
    }
}
