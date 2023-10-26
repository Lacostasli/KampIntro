namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stok = 10000;

            Urun urun2 = new Urun();


            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stok = 500000;

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stok);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("-----------------Metotlar--------------");


            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//metot birçok sayfaya eklenip çağrılabilr durumda
            sepetManager.Ekle(urun2);



            //ekle2 şekli tercih edilmez
            sepetManager.Ekle2("Armut", "Yeşil",12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15);
            sepetManager.Ekle2("KArpuz", "Diyarbakır Karpuzu", 20);




        }
    }
}

// Dont repeat yourself - DRY - Clean Code - Best Practice