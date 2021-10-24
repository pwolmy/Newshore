using Microsoft.AspNetCore.Mvc;
using BL.Models;
using BL.Services;
using Microsoft.Extensions.Logging;


namespace Newshore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportsController : GenericController<Transport>
    {

        public TransportsController(ITransportService service, ILogger<TransportsController> logger) : base(service, logger) { }

    }
}
