using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2
{
    public class Koszyk
    {
        List<Produkt> produkty { get; set; }

        public Koszyk() => produkty = new List<Produkt>();

        public void Dodaj(Produkt produkt) => produkty.Add(produkt);

        public double Podlicz() => produkty.Sum(x => x.Cena);
    }
}
