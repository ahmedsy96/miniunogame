using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSinav
{
    class Deste
    {
        Kart[] kartlar = new Kart[18];//kart sınıfından 18 object oluşturdum her object ayrı karta ait  
        
        public string[] renkler = new string[3] { "Sarı", "Kirmizi", "Mavi" };// kartaların renkleri statik arrayda yerleştirdim 
        public string[] sayilar = new string[6] { "1", "2", "3", "4", "5", "RD" };// her rengin 6 tane kartı var (RD = Renk Degiştir kartı ve rengi yok)
        public void Olustur()
        {
            //string[] renkler = new string[3] { "Sarı", "Kirmizi", "Mavi" };
            //string[] sayilar = new string[6] { "1", "2", "3", "4", "5", "RD" };


            int k = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 6; j++)// her rengin kartları belirtme 
                {
                    kartlar[k] = new Kart();
                    kartlar[k].rengi = renkler[i];
                    kartlar[k].sayisi = sayilar[j];
                    // kartlar[k].puani=puanlar[j];
                    k++;
                }

        }

        public void desteYaz()
        {//test amaçlı 

            for (int k = 0; k < 18; k++)
                kartlar[k].bilgiYaz();
        }

        public void Karistir() //kartları karıştırmak için
        {
            Random sayiGen = new Random();
            for (int k = 0; k< 18; k++)
            {
                int rIndis = sayiGen.Next(0, 18);
                Kart gecici = kartlar[k];
                kartlar[k] = kartlar[rIndis];
                kartlar[rIndis] = gecici;
                
            }
        }
        public Kart Dagit(Deste deste , int indeks)//kartları dağıtmak için kullanılan fonksiyon
        {
            return deste.kartlar[indeks];
                
            
        }

    }
}
