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

        public void Dodaj(Produkt produkt)
        {
            var produktJezeliIstnieje = produkty.Where(x => x.Nazwa == produkt.Nazwa).FirstOrDefault();

            if (produktJezeliIstnieje == null)
            {
                Console.WriteLine("Dodano do koszyka " + produkt.Nazwa);
                produkty.Add(produkt);
            }
            else
            {
                produktJezeliIstnieje.Ilosc++;
                Console.WriteLine("Dodano kolejne "
                    + produkt.Nazwa + " do koszyka (" + produktJezeliIstnieje.Ilosc +").");
            }
            
        }

        public double Podlicz() => produkty.Sum(x => x.Cena);
    }
}
