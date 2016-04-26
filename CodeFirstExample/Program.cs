using DataService;
using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AirLineContext dbContext = new AirLineContext())
            {
                /*
                var ticket = new Ticket
                {
                    TicketType = new TicketType { Type = "Arrived" },
                    Id = 1,
                    Price = 34
                };
                dbContext.Tickets.Add(ticket);
                dbContext.SaveChanges();
                */
                Console.WriteLine(dbContext.Tickets.Count());
            }
            Console.ReadKey();
        }
    }
}
