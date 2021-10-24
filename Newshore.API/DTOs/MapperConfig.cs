using AutoMapper;
using BL.Models;

namespace Newshore.API.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Flight, FlightDTO>(); // GET
                cfg.CreateMap<FlightDTO, Flight>(); // POST - PUT

            });
        }
    }
}
