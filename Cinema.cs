using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
            Console.WriteLine(" Projector ON");
        }

        public void AddTicket(Ticket t) => tickets.Add(t);

        public void Close()
        {
            Console.WriteLine(" Projector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }

        public List<Ticket> GetTickets() => tickets;
    }
}
