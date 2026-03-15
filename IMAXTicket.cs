using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    internal class IMAXTicket:Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string movie, decimal price, bool is3D)
            : base(movie, price) => Is3D = is3D;

        public override decimal CalculateFinalPrice() => Price * 1.14m;
    }
}
