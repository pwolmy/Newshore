using System;
using System.ComponentModel.DataAnnotations;

namespace Newshore.API.DTOs
{
    public class RequestDTO
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public string From { get; set; }
    }
}
