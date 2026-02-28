using assOOP03;

namespace assOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Q1_Part1
            //What is the difference between static binding and dynamic binding? When does each one happen?
            //static -> Look at the variable type when compile time 
            //Dynamic -> Look at the object type when run time
            #endregion
            #region Q2_Part1
            //What is the difference between method overloading and method overriding?
            //overloading ->  look at compile time 
            //overridding -> look at run time 
            #endregion
            #region Q3_Part1
            //What keywords are used for Method Overriding? What does each one mean ?
            // ketwords -> in parent class put on method virtual and child class put override
            //virtual -> can be redefined in a child class
            // override -> this is new implementation of this method 
            #endregion
            #region Part2
            Cinema cinema = new Cinema();
            cinema.OpenCinema();
            StandardTicket standTicket = new StandardTicket("Inception", 150.00m, "A-5");
            VIPTicket vIP = new VIPTicket("Avengers", 200.00m, true);
            IMAXTicket iMAX = new IMAXTicket("Dune", 180.00m, false);
            Console.WriteLine("========SetPrice Test==========");
            Console.WriteLine($"Setting price directily:");
            Ticket ticket = new Ticket("Avengers",50);
            ticket.SetPrice(150.0m);
            Console.WriteLine(ticket.price);
            Console.WriteLine($"Setting price with multiplier:");
            ticket.SetPrice(100, 1.5m);
            Console.WriteLine(ticket.price);
            cinema.AddTicket(standTicket);
            cinema.AddTicket(vIP);
            cinema.AddTicket(iMAX);
            cinema.PrintAllTickets();
            Console.WriteLine("=======Process Single Ticket======");
            Ticket.ProcessTicket(vIP);
            cinema.CloseCinema();
            #endregion
        }
    }
}
