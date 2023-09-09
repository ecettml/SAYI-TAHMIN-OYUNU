using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYI_TAHMIN_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele = new Random();
            hafiza = rastgele.Next(1, 100);
            while(tahmin!= hafiza)
            {
                sayac++;
                Console.Write("Bir sayı giriniz=");
                tahmin = Convert.ToInt16(Console.ReadLine());

                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha küçük sayı giriniz.");

                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha büyük sayı giriniz ");
                }
            }
            Console.WriteLine("TEBRİKLERRRR DOĞRU BİLDİNİZ!!!!!");
            Console.WriteLine("{0}.denemede buldunuz.", sayac);
            Console.ReadLine();
        }
    }
}
