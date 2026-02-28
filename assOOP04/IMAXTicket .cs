using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class IMAXTicket:Ticket
    {
        private bool Is3d;
        public IMAXTicket(string moviename, decimal pri, bool _Is3D):base(moviename,pri)
        {
            Is3d = _Is3D;
            if (Is3d)
            {
                price += 30;
            }
        }
       
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" | Imax 3D : {Is3d}");
        }
    }
}
