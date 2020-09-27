using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSinav
{
    class Program
    {
        static void Main(string[] args)
        {
            Game oyun = new Game();                // oyunumuzu oluşturduk 
            oyun.NewGame();                       // yeni oyun 
            oyun.KartlariDagit();                //kartlar oyunculara dağıtmak
            oyun.PlayGame();                    //oyun başlasın
            Console.ReadKey();
        }
    }
}
