using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO1._2.ObslugaPlatnosci;

namespace ZPO1._2.Platnosci
{
    public class Karta : Platnosc
    {
        private static Karta _karta = null;

        private int _numer { get; set; }
        public int Numer { get => _numer; set => _numer = value; }

        private double _saldo { get; set; }
        public double Saldo { get => _saldo; set => _saldo = value; }

        private DateTime _dataWaznosci { get; set; }
        public DateTime DataWaznosci { get => _dataWaznosci; set => _dataWaznosci = value; }

        public Karta(int saldo)
        {
            this.Saldo = saldo;
        }

        public static Karta KartaPlatnicza
        {
            get
            {
                if (_karta == null)
                {
                    _karta = new Karta(100);
                }
                return _karta;
            }
        }

        public void Zaplac(double suma)
        {
            if (KartaPlatnicza.Saldo >= suma)
            {
                KartaPlatnicza.Saldo -= suma;
            }
            else
            {
                throw new NotEnoughFundsOnCreditCardException(
                    "Brak wystarczajacych srodkow na karcie, posiadasz " + KartaPlatnicza.Saldo + "zl");
            }
        }
    }
}
