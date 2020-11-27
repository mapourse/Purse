using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardNamespace
{
    public class BusinessCard
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public BusinessCard(string companyName, string email, string address)
        {
            CompanyName = companyName;
            Email = email;
            Address = address;
        }
    }
}
