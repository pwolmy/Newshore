using System;
using Xunit;
using Newshore.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest.Unit
{
    public class FlightDTOtest : ControllerBase
    {
        [Fact]
        public void FlightDTOtest_ShouldPass_WhenEverythingIsOk()
        {
            //Arrange
            var _sut = new FlightDTO()
            {
                DepartureDate = DateTime.Parse("2019-08-01T07:35:00"),
                DepartureStation = "MDE",
                ArrivalStation = "BOG",
                FlightNumber = 8020,
                Price = (decimal)23094.0,
                Currency = "COP"
            };

            //Act
            var result = ModelState;

            //Assert
            Assert.True(result.IsValid);
            //result.IsValid.Should().BeTrue();
        }
    }
}
