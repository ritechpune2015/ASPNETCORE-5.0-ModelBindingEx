using System;
using System.Reflection.Metadata.Ecma335;

namespace ModelBindingEx.Models
{
    public class Customer
    {
        public Int64 CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
