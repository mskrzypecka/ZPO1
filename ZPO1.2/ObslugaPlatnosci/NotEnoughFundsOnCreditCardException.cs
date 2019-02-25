using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1._2.ObslugaPlatnosci
{
    public class NotEnoughFundsOnCreditCardException : Exception
    {
        public NotEnoughFundsOnCreditCardException(string message)
              : base("Wyjatek: " + message) { }
    }
}
