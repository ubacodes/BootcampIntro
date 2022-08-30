using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // Do not repeat yourself - kendini tekrarlama
            //alias = takma isim (kategoriEtiketi)
            string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.89;
            //bool sistemeGirisYapmisMi = true;

            Console.WriteLine(kategoriEtiketi);

            /*
            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Giriş Yap butonu");
            }
            else
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            } */

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            { 
                Console.WriteLine("düşüş oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else
            {
                Console.WriteLine("eşittir oku");
            }

        }
    }
}