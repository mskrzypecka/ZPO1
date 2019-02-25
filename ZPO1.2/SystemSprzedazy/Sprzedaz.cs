using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO1._2.ObslugaPlatnosci;
using ZPO1._2.Platnosci;

namespace ZPO1._2
{
    class Sprzedaz
    {
        public void Zaplac(double suma, SposobPlatnosci wybranaPlatnosc)
        {
            Platnosc platnosc = new Platnosc();
            platnosc.zarejestrujPlatnosc();

            switch (wybranaPlatnosc)
            {
                case SposobPlatnosci.Karta:
                    try
                    {
                        platnosc = new Karta(100);
                        ((Karta)platnosc).Zaplac(suma);
                        platnosc.generujPotwierdzenieZamowienia();
                    }
                    catch (NotEnoughFundsOnCreditCardException ex)
                    {
                        //throw new Exception("Platnosc nieudana: " + ex.Message);
                        Console.WriteLine("Platnosc nieudana: " + ex.Message);
                    }
                    break;
                case SposobPlatnosci.Przelew:
                    platnosc = new Przelew();
                    platnosc.generujPotwierdzenieZamowienia();
                    break;
            }
        }
    }
}
