using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2.Platnosci
{
    class Przelew : Platnosc
    {
        private int _numerKonta { get; set; }
        public int NumerKonta { get => _numerKonta; set => _numerKonta = value; }
    }
}
