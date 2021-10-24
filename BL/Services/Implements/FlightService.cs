using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using BL.Repositories;

namespace BL.Services.Implements
{
    public class FlightService : GenericService<Flight>, IFlightService
    {
        public FlightService(IFlightRepository flightRepository) : base(flightRepository)
        {

        }
    }
}
