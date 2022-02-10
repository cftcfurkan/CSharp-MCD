using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrnek
{
    internal class Ogrenci
    {
        public static int OgrenciSayisi = 0;
        public string isim;
        public string soyIsim;
        public Ogrenci()
        {
            OgrenciSayisi++;
        }
    }
}
