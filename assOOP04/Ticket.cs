using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class Ticket
    {
        private  decimal Price;
        private static int totalTicket = 0;
        public String MovieName { get; set; }
        public decimal price
        {
            get { return Price; }
            set
            {
                if (Price > 0)
                {
                    Price = value;
                }
            }
        }
        public void SetPrice(decimal _price)
        {
            price = _price;
        }
        public void SetPrice(decimal _price,decimal multiplier)
        {
            price= _price*multiplier;
        }
        public int TicketId { get; }
        public Ticket (String _moviename,decimal _price)
        {
            MovieName = _moviename;
            Price = _price;
            totalTicket++;
            TicketId=totalTicket;
        }
       
        public decimal PriceAfterTax => Price + (Price * 14 / 100);
      
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket # {TicketId} | {MovieName} | Price : {Price} EGP | After Tax : {PriceAfterTax} EGP");
        }
        public static int GetTotalTickets()
        {
            return totalTicket;
        }
        public static void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
        }
    }
}
