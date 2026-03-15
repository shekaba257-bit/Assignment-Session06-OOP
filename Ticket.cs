using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session06_OOP
{
    public abstract class Ticket
    {
        public string Movie { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        public Ticket(string movie, decimal price)
        {
            Movie = movie;
            Price = price;
        }

        // Abstract method: must be implemented by child classes
        public abstract decimal CalculateFinalPrice();

        // Concrete method: shared behavior
        public void Book() => IsBooked = true;

        // Virtual method: can be overridden if needed
        public virtual void Cancel() => IsBooked = false;
    }
}
