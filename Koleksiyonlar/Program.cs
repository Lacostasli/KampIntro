using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)

            //ctrl + k  ve ctrl+c (comment) tam tersi ctrl+k ve ctrl+u (uncomment)
        {
            //string[] isimler = new string[] { "Aslı", "Alper", "Gökhan ", "İrem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
          
            //isimler = new string[5];  yeniden newlenen yapıda yeni bir adrs tanımlaması yapılmıştır.
            //Bu yapıda 0.eleman boş olması sebebiyle bi veri vermez, 4.elemana yeni isim tanımladığı için
            //yalnızca 4.elemanda bir veriye ulaşır. diğer veriler newleme işlemi sebebiyle boştur, farklı alan adresi oluşmuştur.
            //isimler[4] = "Atike";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            
            //Doğru kullanım şekline list elemanı ile bakıyoruz. List bir sınıftır.(yeşil renk)
            List<string> isimler2 = new List<string> { "Aslı", "Alper", "Gökhan ", "İrem" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //Koleksiyonlarda arraylar gibi ekleme yapabileceğimiz bir alt yapı mevcuttur - örnek:
            isimler2.Add("Atike");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            //ÖNEMLİİİİ!!
            // isimler = new string[5];//genişletme ile öncek değerleri kaybediyoruz!
            // isimler[4] = "Atike"; //5.eleman olarak Atike ismini array e ekler ve yazdırır. 
            //  Console.WriteLine(isimler[4]);
            // Console.WriteLine(isimler[0]);//Fakat daha önceki liste elemanalrını çağırmak istersek boş eleman gelir, sebebi yeniden isimler arrayini newlememizdir.




        }
    }
}