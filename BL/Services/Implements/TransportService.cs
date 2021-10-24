using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using BL.Repositories;
//using BL.Repositories;

namespace BL.Services.Implements
{
    public class TransportService : GenericService<Transport>, ITransportService
    {

        public TransportService(ITransportRepository transportRepository) : base(transportRepository) {}

    }
}
