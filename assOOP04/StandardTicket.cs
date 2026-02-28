using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class StandardTicket:Ticket
    {
        public string seatNumber { get; set; }
        public StandardTicket(string moviename,decimal pri,string _seatnumber) : base(moviename, pri)
        {
            seatNumber=_seatnumber;
        }
       
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" | seat : {seatNumber}");
        }
    }
}
