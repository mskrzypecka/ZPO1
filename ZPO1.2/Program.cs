using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszyk = new Koszyk();

            for (int i = 0; i < 10; i++)
            {
                koszyk.Dodaj(new Produkt("Mleko", 3));
                koszyk.Dodaj(new Produkt("Chleb", 5));
                koszyk.Dodaj(new Produkt("Maslo", 5));

                Sprzedaz sprzedaz = new Sprzedaz();
                sprzedaz.Zaplac(koszyk.Podlicz(), SposobPlatnosci.Karta);
                Console.WriteLine("Zakupy {0} zakonczone.", i);
                koszyk = new Koszyk();
            }

            Console.WriteLine("Wyjscie ze sklepu.");
            Console.ReadKey();
        }
        
    }
    enum SposobPlatnosci
    {
        Karta,
        Przelew
    }
}
