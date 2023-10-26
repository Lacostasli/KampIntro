using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) 
        
        {
            Console.WriteLine("Sepete Eklendi!" + urun.Adi);
        
        }
        //Yanlış yazım aşağıdaki kod - Ekle2
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler, sepete eklendi.."+ urunAdi);
        
        
        }
    }
}
