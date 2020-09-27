using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraSinav
{
    class Oyuncular
    {
        public string[]names = new string[3];// oyuncuların isimlerinin listesi 
        
       public List<Kart>[] kartlarim = new List<Kart>[3];//bu arrayda 3 iç arrayı var her oyuncunun ayrı bir arryı var ve her arrayda 6 kart nesnesi var 

        public Oyuncular()
        {
            for (int i = 0; i < 3; i++)
            {
                kartlarim[i] = new List<Kart>();


            }
        }
        
    }
  
}
