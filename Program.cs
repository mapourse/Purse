using CreditCardNamespace;
using MoneyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(20, Currencies.USD);
            CreditCard cc = new CreditCard("0000323", 45000, 1);
        }
    }
}
