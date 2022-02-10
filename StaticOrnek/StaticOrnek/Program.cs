using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static sınıf üyelerine erişim
            Console.WriteLine("Öğrenci Sayısı : "+Ogrenci.OgrenciSayisi);

            //static olmayan sınıf üyelerine erişim 
            Ogrenci o1 = new Ogrenci();
            o1.isim = "Furkan";
            o1.soyIsim = "Çiftci";
            Ogrenci o2 = new Ogrenci();
            o2.isim = " Buse";
            o2.soyIsim = " Yılmaz";

            Console.WriteLine("Öğrenci sayısı : "+Ogrenci.OgrenciSayisi);
        }
    }
}
