using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSinav
{
    class Game
    {
        Deste destem = new Deste();// deste nesnesinii oluşturduk 
        Oyuncular oyuncularimiz = new Oyuncular();// oyuncular nesnesinii oluşturduk 


        public int Kartimindexi = 0;
        public void NewGame()
        {

            destem.Olustur();//destemiz oluşturduk
            destem.Karistir();//kartlarımızı karıştırdık

        }
        public void KartlariDagit()// kartları oyunculara dagıtma fonksiyonumuz 
        {



            
            Console.Write("{0} . Oyuncu Adini Giriniz :", 1);
            string isim = Console.ReadLine();

            oyuncularimiz.names[0] = isim;
            string bilgisayar1 = "Bilgisayar 1";
            string bilgisayar2 = "Bilgisayar 2";
            oyuncularimiz.names[1] = bilgisayar1;
            oyuncularimiz.names[2] = bilgisayar2;



            for (int j = 0; j < 6; j++)
            {

                oyuncularimiz.kartlarim[0].Add(destem.Dagit(destem, j));
                oyuncularimiz.kartlarim[1].Add((destem.Dagit(destem, j + (6 * 1))));
                oyuncularimiz.kartlarim[2].Add((destem.Dagit(destem, j + (6 * 2))));
            }
            for (int o = 0; o < 3; o++)// her oyuncunun kagitlari yazdirmak
            {

                Console.WriteLine("{0}'in kartlar :", oyuncularimiz.names[o]);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}.Kart : ", j + 1);
                    oyuncularimiz.kartlarim[o][j].bilgiYaz();
                }

            }
        }










        bool renk = false;
        bool rd = true;
        bool pasyap = true;
        public bool ilkatama = true;// ilk atamada RD yapmamak için
        int pas = 0;
        public void PlayGame()
        {
            Console.WriteLine("Seçeceğiniz kartın sol tarafındaki kart numarasını klavyeden gir ");
            Console.WriteLine("******************** ");


            Kart yerdeKart = new Kart();//Yerde kart nesnesi

            int i = 0;
            bool biter = false;// oyun bittiğinde true olacak
            while (biter == false)
            {
                
                while (i < 3)// 3 hamlemiz var 
                {
                    renk = false;
                    rd = true;

                    if (pas == 3)// 3 hamle boyunca yerde kart değiştirilmemiş ise oyunu biter 
                    {
                        Console.WriteLine("********************************");
                        Console.WriteLine("Oyun Bire birebir Bitti");
                        biter = true;
                        break;
                    }


                    if (i == 0)
                    {
                        Console.WriteLine("{0} Seçeceğiniz kartın sol tarafındaki kart numarasını klavyeden gir , pas için 7 girin /ilk atamada haric/", oyuncularimiz.names[i]);
                        string sirastr = Console.ReadLine();// kullanıcıdan atılacak kartın sırasını alır 
                        int sira = Convert.ToInt32(sirastr);

                        if (ilkatama == true)//eğer daha yerde kart yok (RD ile başlamamak için )
                        {

                            if (sira > 0 && sira < oyuncularimiz.kartlarim[i].Count + 1 && oyuncularimiz.kartlarim[i][sira - 1].sayisi != "RD")
                            {
                                ilkatama = false;
                                yerdeKart = oyuncularimiz.kartlarim[i][sira - 1];//yeni oyuncu kart attığında yerdekartın değeri değiştirilir
                                oyuncularimiz.kartlarim[i].RemoveAt(sira - 1);//kullanıcı attığı kart kullanıcının listesinden silinir 

                                Console.WriteLine("Yerde Kart");
                                yerdeKart.bilgiYaz();// 
                                Console.WriteLine("***********************");
                                if (pas > 0)// yerde kart 2 ya da 1 hamle boyunca değiştirlmediyse ve bu hamlede değiştirildiyse pas 0 olur 
                                {
                                    pas = 0;
                                }

                                i++;
                            }
                           
                            else
                            {
                                Console.WriteLine("Hataa !! Tekrar seçiniz");

                            }



                        }

                        else//eğer bu atama ilk atama değil yani yerde kart var 
                        {
                            if (sira >= 0 && sira < oyuncularimiz.kartlarim[i].Count + 1)
                            {
                                if (oyuncularimiz.kartlarim[i][sira - 1].sayisi != "RD")// atılan kart RD değilse 
                                {
                                    if (yerdeKart.rengi == oyuncularimiz.kartlarim[i][sira - 1].rengi || yerdeKart.sayisi == oyuncularimiz.kartlarim[i][sira - 1].sayisi)//kart şartları sağlıyorsa 
                                    {
                                        yerdeKart = oyuncularimiz.kartlarim[i][sira - 1];
                                        oyuncularimiz.kartlarim[i].RemoveAt(sira - 1);
                                        Console.WriteLine("Yerde Kart");
                                        yerdeKart.bilgiYaz();
                                        Console.WriteLine("***********************");


                                    }
                                    else// kart şartları sağlamıyorsa 
                                    {
                                        Console.WriteLine("Hataa !! Tekrar seçiniz");
                                        continue;
                                    }

                                }
                                else if (oyuncularimiz.kartlarim[i][sira - 1].sayisi == "RD")// atılan kart RD ise

                                {



                                    for (int renk = 0; renk < 3; renk++)// yeni renk secmek için
                                    {

                                        Console.WriteLine(" Eger {0} kart isterseniz : {1}e basiniz ! ", destem.renkler[renk], renk + 1);

                                    }

                                    string yenirenk = Console.ReadLine();
                                    int renkinedeksi = Convert.ToInt32(yenirenk) - 1;
                                    if (renkinedeksi <= 2)
                                    {
                                        oyuncularimiz.kartlarim[i].RemoveAt(sira - 1);
                                        Console.WriteLine("Rengi degistir kartini sectiniz !");

                                        yerdeKart.rengi = destem.renkler[renkinedeksi];
                                        Console.WriteLine("Yerde Kart");
                                        yerdeKart.bilgiYaz();
                                        Console.WriteLine("***********************");
                                        
                                        if (pas > 0)
                                        {
                                            pas = 0;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Oyle bir renk yok Tekrar kart seçin");
                                        continue;
                                    }



                                }

                                if (oyuncularimiz.kartlarim[i].Count == 0)//oyuncunun hiç kartı kalmadıysa
                                {
                                    Console.WriteLine("{0} kazandi Tebrikleeeer !!!", oyuncularimiz.names[i]);
                                    biter = true;// whileden çıkacak ve oyun biter
                                    break;
                                }

                                i++;
                            }
                            else if (sira == 7)
                            {
                                Console.WriteLine("Pas edildi !");
                                Console.WriteLine("Yerde Kart");
                                yerdeKart.bilgiYaz();
                                Console.WriteLine("***********************");
                                i++;
                                pas++;

                            }
                            else
                            {
                                Console.WriteLine("Hataa !! Tekrar seçiniz");

                            }

                        }
                    }

                    else//Bilgisayarın oyuncularının sırası
                    {
                        

                        for (int kart = 0; kart < oyuncularimiz.kartlarim[i].Count ; kart++)
                        {
                            if (oyuncularimiz.kartlarim[i][kart].sayisi != "RD")
                            {
                                if (oyuncularimiz.kartlarim[i][kart].sayisi == yerdeKart.sayisi || oyuncularimiz.kartlarim[i][kart].rengi == yerdeKart.rengi)
                                {
                                    yerdeKart = oyuncularimiz.kartlarim[i][kart];
                                    oyuncularimiz.kartlarim[i].RemoveAt(kart);
                                    Console.WriteLine("Bilgisayar {0} . oyuncusunun sırası :", i);
                                    Console.WriteLine("Yerde Kart");
                                    yerdeKart.bilgiYaz();
                                    Console.WriteLine("**********Enter Bas*************");
                             
                                    Console.ReadLine();
                                    rd = false;
                                    pasyap = false;
                                    break;

                                }
                            }

                        }
                        
                        if (rd == true)
                        {
                            
                            Random sayiGen = new Random();
                            for (int kart = 0; kart < oyuncularimiz.kartlarim[i].Count ; kart++)
                            {
                                if (oyuncularimiz.kartlarim[i][kart].sayisi == "RD")
                                {




                                    while (renk == false)
                                    {
                                        int yenirenkindeksi = sayiGen.Next(0, 2);
                                        if (destem.renkler[yenirenkindeksi] != yerdeKart.rengi)
                                        {

                                            oyuncularimiz.kartlarim[i].RemoveAt(kart);
                                            Console.WriteLine("Rengi degistir kartini sectiniz !");

                                            yerdeKart.rengi = destem.renkler[yenirenkindeksi];
                                            Console.WriteLine("Bilgisayar {0} . oyuncusunun sırası :", i);
                                            Console.WriteLine("renk degistirildi!!");
                                            Console.WriteLine("Yerde Kart");
                                            yerdeKart.bilgiYaz();
                                            Console.WriteLine("**********Enter Bas*************");
                                            Console.ReadLine();
                                            if (pas > 0)
                                            {
                                                pas = 0;
                                            }
                                            renk = true;
                                            
                                        }
                                    }
                                    pasyap = false;


                                }
                            }
                        }
                        if (oyuncularimiz.kartlarim[i].Count == 0)//oyuncunun hiç kartı kalmadıysa
                        {
                            Console.WriteLine("{0} kazandi Tebrikleeeer !!!", oyuncularimiz.names[i]);
                            biter = true;// whileden çıkacak ve oyun biter
                            break;
                        }

                        
                        if (pasyap == true)
                        {
                            Console.WriteLine("Bilgisayar {0} . oyuncusunun sırası :", i);

                            Console.WriteLine("Pas edildi !");
                            Console.WriteLine("Yerde Kart");
                            yerdeKart.bilgiYaz();
                            Console.WriteLine("**********Enter Bas*************");
                            Console.ReadLine();
                            
                            pas++;

                        }
                        i++;

                    }

                    if (i > 2)// yeni hamle başlamak için
                    {

                        for (int k = 0; k < 3; k++)
                        {

                            Console.WriteLine("{0}'in kartlar :", oyuncularimiz.names[k]);
                            for (int j = 0; j < oyuncularimiz.kartlarim[k].Count; j++)
                            {
                                Console.Write("{0}.Kart : ", j + 1);
                                oyuncularimiz.kartlarim[k][j].bilgiYaz();
                            }
                            Console.WriteLine("**********************");
                        }


                        
                        Console.WriteLine("Yerde Kart");
                        yerdeKart.bilgiYaz();
                        Console.WriteLine("***********************");

                        i = 0;

                    }
                }



            }


        }

    }
}

    