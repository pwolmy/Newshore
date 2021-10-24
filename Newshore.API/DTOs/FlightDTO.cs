using System;

namespace Newshore.API.DTOs
{
    public class FlightDTO
    {
        public DateTime DepartureDate { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }

        public decimal Price { get; set; }
        public string Currency { get; set; }

        public int FlightNumber { get; set; }
    }
}
