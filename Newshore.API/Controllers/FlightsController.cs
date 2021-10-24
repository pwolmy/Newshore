using Microsoft.AspNetCore.Mvc;
using BL.Models;
using BL.Services;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

using Newshore.API.DTOs;
using Microsoft.EntityFrameworkCore;



namespace Newshore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : GenericController<Flight>
    {

        public FlightsController(IFlightService service, ILogger<FlightsController> logger) : base(service, logger) { }

    }
}
