using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2.Platnosci
{
    class Karta : IPlatnosc
    {
        private int _numer { get; set; }
        private DateTime _dataWaznosci { get; set; }

        public void generujPotwierdzenieZamowienia()
        {
            throw new NotImplementedException();
        }

        public void zarejestrujPlatnosc()
        {
            throw new NotImplementedException();
        }
    }
}
