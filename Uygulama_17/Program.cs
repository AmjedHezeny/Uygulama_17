using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_17
{
    internal class Program
    {
        static string[] isimler = new string[]
        {        
        "Demircan Baydil.",
        "Burçin Kübra Baykal.",
        "Derviş Haluk Baykan.",
        "Taylan Remzi Baykuş.",
        "Abdulvahap Bayrakoğlu.",
        "Aygün Bayram.",
        "Ayla Baytın.",
        "Kubilay Barış Begiç."
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Programımıza hoş Geldiniz :)");
                Console.WriteLine("1).İsimleri Listele.");
                Console.WriteLine("2).Kişi Sayısı.");
                Console.WriteLine("3).En Uzun İsimli öğrencinin İsmi.");
                Console.WriteLine("4).İsimlerin Alfabetik Sıralaması.");
                Console.WriteLine("5).Girilen Harf İle Başlayan İsimler.");
                Console.WriteLine("0).Çıkış.");

                Console.Write("Seçiminizi Yapınız: ");
                char seçme = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

                try
                {
                    switch (seçme)
                    {
                        case '1':
                            Metodlar.Listele(isimler);
                            break;
                        case '2':
                            Metodlar.KisiSayisi(isimler);
                            break;
                        case '3':
                            Metodlar.EnUzunIsim(isimler);
                            break;
                        case '4':
                            Metodlar.AlfabetikSiralama(isimler);
                            break;
                        case '5':
                            Metodlar.HarfIleBaslayanIsimler(isimler);
                            break;
                        case '0':
                            Console.WriteLine("Programı kullandığınız için teşekkür ederiz. Çıkış için herhangi bir tuşa basınız.");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Geçersiz bir seçim yaptınız.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }
        }
    }
}





