using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    internal class VIPTicket :Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal Fee { get; set; }
        public VIPTicket(string movie, decimal price, bool lounge, decimal fee)
            : base(movie, price) { LoungeAccess = lounge; Fee = fee; }

        public override decimal CalculateFinalPrice() => (Price + Fee) * 1.25m;
    }
}
