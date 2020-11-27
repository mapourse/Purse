using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardNamespace
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public decimal Limit { get; set; }
        public uint SecurityPin { get; set; }

        public CreditCard(string cardNumber, decimal limit, uint securityPin)
        {
            CardNumber = cardNumber;
            Limit = limit;
            SecurityPin = securityPin;
        }
    }
}
