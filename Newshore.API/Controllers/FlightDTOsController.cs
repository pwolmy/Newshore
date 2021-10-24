using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using BL.Services;
using BL.Models;
using Newshore.API.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace Newshore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDTOsController : ControllerBase
    {

        private readonly ILogger<FlightDTOsController> _logger;
        public IMapper mapper;
        public readonly IFlightService _service;
        public readonly ITransportService _serviceT;

        public FlightDTOsController(IFlightService service, ITransportService serviceT, ILogger<FlightDTOsController> logger)
        {
            _service = service;
            _serviceT = serviceT;
            _logger = logger;
            this.mapper = Startup.MapperConfiguration.CreateMapper();
        }

        // POST: api/CoursesApi
        [HttpPost]
        /*[EnableCors("AllowOrigin")]*/
        public async Task<ActionResult> PostCourse(FlightDTO flightDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var flight = mapper.Map<Flight>(flightDTO);
                
                var transport = _serviceT.GetById(flightDTO.FlightNumber).Result;
                if (transport == null)
                {
                    transport = new Transport() { FlightNumber = flightDTO.FlightNumber };
                    await _serviceT.Insert(transport);
                }
                
                await _service.Insert(flight);
                return Ok(flightDTO);
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.)
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }

}
