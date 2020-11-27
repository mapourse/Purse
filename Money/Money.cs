using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyNamespace
{
    public enum Currencies { USD, EUR, UAH }

    public class Money
    {
        public uint Amount { get; set; }
        public Currencies Currency { get; set; }

        public Money(uint amount, Currencies currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
