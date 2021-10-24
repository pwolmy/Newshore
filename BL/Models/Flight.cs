using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class Flight
    {
        public int FlightID { get; set; }

        public int FlightNumber { get; set; }

        public DateTime DepartureDate { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }

        public decimal Price { get; set; }
        public string Currency { get; set; }
        
    }
}
