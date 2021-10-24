using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.DATA
{
    public class DbInitializer
    {
        public static void Initialize(NewshoreContext context)
        {
            context.Database.EnsureCreated();

            /*
            if (context.Flights.Any())
            {
                return;   // DB has been seeded
            }

            var transports = new Transport[]
            {
                new Transport{ FlightNumber =8020},
                new Transport{ FlightNumber =811},
            };
            foreach (var item in transports)
            {
                context.Transports.Add(item);
            }
            context.SaveChanges();



            var flights = new Flight[]
            {
                new Flight{
                    DepartureDate =  DateTime.Parse("2019-08-01T07:35:00"),
                    DepartureStation = "MDE",
                    ArrivalStation = "BOG",
                    FlightNumber = 8020,
                    Price = (decimal)23094.0,
                    Currency = "COP"
                },
                new Flight{
                    DepartureDate =  DateTime.Parse("2019-08-01T15:01:00"),
                    DepartureStation = "MDE",
                    ArrivalStation = "BOG",
                    FlightNumber = 811,
                    Price = (decimal)23094.0,
                    Currency = "COP"
                },
            };
            foreach (var item in flights)
            {
                context.Flights.Add(item);
            }
            context.SaveChanges();
            */
        }
    }
}
