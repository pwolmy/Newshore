using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using BL.DATA;

namespace BL.Repositories.Implements
{
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        public FlightRepository(NewshoreContext context) : base(context)
        {

        }
    }
}
