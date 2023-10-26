namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2="Programlamaya başlangı için temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangı için temel kurs" , "Java", "C++", "Python" };

            for (int i = 0; i < kurslar.Length; i++) // kurslar dizisinin uzunluğu kadar yaz
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)// dizi temelli yapıları tek tek dönmeye yarar - kurslar yapısını tek tek dolaş(for ya da foreach olabilir ikisini de aynısını veriyor)
            {
                Console.WriteLine(kurs);

            }
            


        }
    }
} 