using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZPO1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszyk = new Koszyk();

            for (int i = 0; i < 15; )
            {
                for(int j = 0; j < 5; j++)
                    koszyk.Dodaj(wylosujProdukt());

                Sprzedaz sprzedaz = new Sprzedaz();
                sprzedaz.Zaplac(koszyk.Podlicz(), SposobPlatnosci.Karta);
                Console.WriteLine("Zakupy {0} zakonczone.", ++i);
                Console.WriteLine("___________________________________");
                koszyk = new Koszyk();
            }

            Console.WriteLine("Wyjscie ze sklepu.");
            Console.ReadKey();
        }

        private static Produkt wylosujProdukt()
        {
            Random r = new Random();
            string nazwa = "";
            int cena = 0;
            int current = (int) r.Next(3);
            switch (current)
            {
                case 0:
                    nazwa = "Mleko";
                    cena = 3;
                    break;
                case 1:
                    nazwa = "Chleb";
                    cena = 5;
                    break;
                case 2:
                    nazwa = "Siano";
                    cena = 1;
                    break;
            }
            Thread.Sleep(250);
            return new Produkt(nazwa, cena);
        }
        
    }
    enum SposobPlatnosci
    {
        Karta,
        Przelew
    }
}
