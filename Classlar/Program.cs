using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kurs nesnesi türetiyoruz. Benzer yapıda nesneler..
            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "Yazılım geliştirici yetiştirme kampı";
            kurs1.kursEgitmeni = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();

            kurs2.kursAdi = "C#";
            kurs2.kursEgitmeni = "Turgut Reis";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Matlab";
            kurs3.kursEgitmeni = "Mert Kurt";
            kurs3.izlenmeOrani = 80;

            /*  statik yapı (manuel)
            Console.WriteLine(kurs1.kursAdi + kurs1.kursEgitmeni + kurs1.izlenmeOrani.ToString());
            Console.WriteLine(kurs2.kursAdi + kurs2.kursEgitmeni + kurs2.izlenmeOrani.ToString());
            */

            //dinamik yapı
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs Adi : " + kurs.kursAdi);
                Console.WriteLine("Kurs Eğitmeni : " + kurs.kursEgitmeni); 
                Console.WriteLine("Kurs İzlenme Orani : " + kurs.izlenmeOrani);
            }
            Console.WriteLine("\n" + "// Foreach döngüsü çalışmasını tamamladı. //");

        }
    }
    class Kurs
    {
        //prop = property
        //kurs tipinde classın özelliklerine prop denir farklı değişken tiplerinde olabilir.
        public string kursAdi { get; set; }
        public string kursEgitmeni { get; set; }
        public int izlenmeOrani { get; set; }
    }
}