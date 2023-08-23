using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_17
{
    internal class Metodlar
    {
        public static void Listele(string[] isimler)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Listelemiş İsimler.");
            Console.WriteLine("*********************");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine();
        }
                //-------------------------------------------------

        public static void KisiSayisi(string[] isimler)
        {
            Console.WriteLine("*********************");
            Console.WriteLine($"Kişi Sayısı: {isimler.Length}");
            Console.WriteLine("*********************");
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void EnUzunIsim(string[] isimler)
        {
            string enUzunIsim = "";
            int enUzunIsimUzunlugu = 0;

            foreach (var isim in isimler)
            {
                if (isim.Length > enUzunIsimUzunlugu)
                {
                    enUzunIsim = isim;
                    enUzunIsimUzunlugu = isim.Length;
                }
            }
            Console.WriteLine("*********************");
            Console.WriteLine($"En Uzun İsimli Öğrenci: {enUzunIsim}");
            Console.WriteLine("*********************");
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void AlfabetikSiralama(string[] isimler)
        {
            Array.Sort(isimler, StringComparer.CurrentCultureIgnoreCase);

            Console.WriteLine("İsimlerin Alfabetik Sıralaması.");
            Console.WriteLine("*********************");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine();
        }
        //-------------------------------------------------

        public static void HarfIleBaslayanIsimler(string[] isimler)
        {
            Console.WriteLine("*********************");
            Console.Write("Başlamasını İstediğiniz Harfi Giriniz: ");
            char harf = char.ToLower(Console.ReadLine()[0]);
            Console.WriteLine("*********************");
            Console.WriteLine("Girilen Harfle Başlayan İsimler.");
            Console.WriteLine("*********************");

            foreach (var isim in isimler)
            {
                if (char.ToLower(isim[0]) == harf)
                {
                    Console.WriteLine(isim);
                }
            }
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine();
        }
    }
}

