using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2.Platnosci
{
    public class Platnosc : IPlatnosc
    {
        public string Id { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public double Wartosc { get; set; }

        public void generujPotwierdzenieZamowienia()
        {
            Console.WriteLine("Potwierdzenie zamowienia.");
        }

        public void zarejestrujPlatnosc()
        {
            Console.WriteLine("Zarejestrowanie platnosci.");
        }
    }
}
