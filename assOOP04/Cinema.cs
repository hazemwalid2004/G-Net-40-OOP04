using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class Cinema
    {
        public string CinemaName { get; set; }
        private Projector proj=new Projector();
        private Ticket[] tickets = new Ticket[20];
        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
        public virtual void PrintAllTickets()
        {
            Console.WriteLine("====All Tickets====");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    break; 
                }
                tickets[i].PrintTicket();
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========Cinema Opened========");
            proj.startprojector();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema closed========");
            proj.stopprojector();
        }
    }
}
