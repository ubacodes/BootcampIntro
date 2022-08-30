using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Donguler : birbirine benzeyen (tekrar eden) işlemleri yaptırmak için kullanırız.

            //array = dizi 
            String[] krediler = new string[] { "İhtiyaç Kredisi", "Taşıt Kredisi", "Konut Kredisi", "Aidatsız Kredi" };
            String[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Yazılım Geliştirme Temel Kampı", "Java Geliştirici Kampı", "Python Yazılım Kampı" };
            //String[] krediler = kurslariGetir(); (Gerçek hayatta benzer şekilde bir fonksiyon ile dataları diziye çekiyoruz.)
             

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }
            Console.WriteLine("\n" + "// For döngüsü çalışmasını bitirdi. //" + "\n");

            foreach (string kredi in krediler)
            {
                Console.WriteLine(kredi);
            }
            Console.WriteLine("\n" + "// Foreach döngüsü çalışmasını bitirdi. //" + "\n");

            Console.WriteLine("\n" + "// sayfa sonu - footer //" + "\n");
        }
    }
}