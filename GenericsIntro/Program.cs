namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        MyList<string> isimler = new MyList<string>();
            isimler.Add("Aslı");

            Console.WriteLine(isimler.Length);
            isimler.Add("Özge");

            Console.WriteLine(isimler.Length);//isim sayısını getirir


            //kaç tane isim varsa o isimleri listeler
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
          //  List<String> liste = new List<string>();
           // Console.WriteLine(liste.Count);


        }
    }
}