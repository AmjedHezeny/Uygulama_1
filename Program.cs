using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WriteLine VE Write Komutu
            Console.WriteLine("EMCET");
            Console.WriteLine("Hello Word");
            Console.WriteLine("Merhaba Emcet Hazani");
            Console.Write("Bu tarih düğdüm: ");
            Console.WriteLine("01,06,1997");
            Console.WriteLine("Yaşım:" + 28);

            Console.WriteLine("*********************************************");

            // String Değişkeni

            string yazı = "Nasılsın Emcet Bey '_'";
            Console.WriteLine(yazı);

            Console.WriteLine("*********************************************");

            string adı = "Emcet";
            string soyadı = "Hazani";
            Console.WriteLine("Adım : " + adı);
            Console.WriteLine("Soyadım : " + soyadı);

            Console.WriteLine("*********************************************");

            // int Değişkeni

            int sayı = 1997;
            Console.WriteLine("Düğüm Yılınız : " + sayı);

            Console.WriteLine("*********************************************");

            int sayı_1 = 34;
            int sayı_2 = 66;
            int sayı_3 = 20;
            Console.WriteLine("Sayılar : " + sayı_1 + " <> " + sayı_2 + " <> " + sayı_3);


            Console.WriteLine("*********************************************");

            string adı_ve_soyadım = "Emcet Hazani";
            int yes = 27;
            string mamlakat = "İstanbul";
            string telfon = "05511659688";

            Console.WriteLine("Ad Soyad : " + adı_ve_soyadım + "\nYaş : " + yes);
            Console.WriteLine("Memleket : " + mamlakat + "\nTelfonNo : " + telfon);




            Console.ReadKey();
        }
    }
}
