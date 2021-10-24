using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using BL.DATA;

namespace BL.Repositories.Implements
{
    public class TransportRepository : GenericRepository<Transport>, ITransportRepository
    {
        public TransportRepository(NewshoreContext context) : base(context)
        {

        }

    }
}
