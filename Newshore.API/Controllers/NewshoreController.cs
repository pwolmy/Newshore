using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newshore.API.DTOs;
using BL.Models;
using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace Newshore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewshoreController : ControllerBase
    {
        private IMapper mapper;

        public NewshoreController()
        {
            this.mapper = Startup.MapperConfiguration.CreateMapper();
        }


        // GET: api/<NewshoreController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var request = new RequestDTO { Origin = "BOG", Destination = "CTG", From ="2021-11-20" };
            var flights = await SearchFlights(request);
            var flightsDTO = flights.Select(c => mapper.Map<FlightDTO>(c));
            return Ok(flightsDTO);
        }


        // POST api/<NewshoreController>
        [HttpPost]
        public async Task<IEnumerable<FlightDTO>> Post([FromBody] RequestDTO requestDTO)
        {
            var flights = await SearchFlights(requestDTO);
            var flightsDTO = flights.Select(c => mapper.Map<FlightDTO>(c));
            return flightsDTO;

        }



        private async Task<List<FlightDTO>> SearchFlights(RequestDTO request)
        {
            var url = "http://testapi.vivaair.com/otatest/api/values";
            List<FlightDTO> flightList = new List<FlightDTO>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsJsonAsync(url, request);

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync();

                    var jsonResult = JsonConvert.DeserializeObject(data.Result).ToString();
                    flightList = JsonConvert.DeserializeObject<List<FlightDTO>>(jsonResult);
                }
            }

            return flightList;
        }
    }
}
