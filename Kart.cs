using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSinav
{
    class Kart// Kart kalsımız 2 tane ozellikleri var renk ve sayı
    {
        public string rengi;
        public string sayisi;
        // public int puani;

        public void bilgiYaz()  // kartın detaylarını yazdırmak için
        {
            if (sayisi == "RD")//RD Kartın sayısı RD ve Rengi yok
            {
                Console.WriteLine(sayisi);
            }
            else
            {
                Console.WriteLine("{0}-{1}", rengi, sayisi);

            }
        }
    }
}



