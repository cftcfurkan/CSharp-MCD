using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            /*
             * Matematik adında bir class oluşturun.
             * bir menu hazırlayın metot ile 
             * menüde
             * "****Menü****"
             * "1 - Toplama "
             * "2 - Çıkartma "
             * "3 - Çarpma
             * "4 - Bölme
             * "Lütfen bir değer seçiniz:"
             * Metot ile 4 işlemleri ekrana yazdır metot ile yazdırılacak
             * public static void içinde
             * Matematik sınıfının bir instance'ini al 
             * Kullanıcıdan 2 değer iste ve Matemetik sınıfındaki 4 işlem metodunu kullanarak
             * sonuçları ekrana yazdır. switvh case
             * Yeniden işlem yapmak istiyormusunuz? (E/H) sorunuz.
             * 
             */
            #endregion


            Matematik M = new Matematik();
            yenidenIslemYap:
            M.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. sayı değerini giriniz: ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayı değerini giriniz: ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1://Toplama
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2://Cikartma
                    sonuc = M.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3://Carpma
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                case 4://Bölme
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto yenidenIslemYap;
            }

            Console.WriteLine("Yeni bir işlem yapmak istiyor musunuz?(E/H)");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto yenidenIslemYap;
            }

        }
    }
}
