using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    public static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket t)
        {
            return $@"========== RECEIPT ==========
             Movie    : {t.Movie}
             Type     : {t.GetType().Name}
             Price    : {t.Price}
             Final    : {t.CalculateFinalPrice():F2}
             Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
             =============================";
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            return tickets.Sum(t => t.CalculateFinalPrice());
        }
    }
}
