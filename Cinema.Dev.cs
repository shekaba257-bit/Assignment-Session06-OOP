using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("\n --- All Tickets (from Cinema.Reporting) ---");
            int i = 1;
            foreach (var t in tickets)
            {
                Console.WriteLine($" [Ticket #{i}] {t.Movie} | {t.GetType().Name} | Price: {t.Price} | Final: {t.CalculateFinalPrice():F2} | Booked: {t.IsBooked}");
                i++;
            }
        }
    }
}
