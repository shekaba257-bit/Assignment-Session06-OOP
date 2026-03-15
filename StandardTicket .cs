using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    internal class StandardTicket:Ticket
    {
        public string Seat { get; set; }
        public StandardTicket(string movie, decimal price, string seat)
            : base(movie, price) => Seat = seat;

        public override decimal CalculateFinalPrice() => Price * 1.14m; // VAT
    }
}
