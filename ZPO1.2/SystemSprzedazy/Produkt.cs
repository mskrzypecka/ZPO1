using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Produkt(string nazwa, double cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}
