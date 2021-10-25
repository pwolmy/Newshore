using System;
using Xunit;
using Newshore.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UnitTest.Unit
{
    public class FlightDTOtest : ControllerBase
    {
        [Fact]
        public void Validate_FlightDTO_Valid_Test()
        {
            //Arrange
            var model = new FlightDTO()
            {
                DepartureDate = DateTime.Parse("2019-08-01T07:35:00"),
                DepartureStation = "MDE",
                ArrivalStation = "BOG",
                FlightNumber = 8020,
                Price = (decimal)23094.0,
                Currency = "COP"
            };

            //Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(model, new ValidationContext(model), validationResults, true);

            //Assert
            Assert.True(actual, "Expected validation to succeed.");
        }

        [Fact]
        public void Validate_FlightDTO_MakeRequired_Test()
        {
            //Arrange
            var model = new FlightDTO()
            {
                DepartureDate = DateTime.Parse("2019-08-01T07:35:00"),
                DepartureStation = null,
                ArrivalStation = "BOG",
                FlightNumber = 8020,
                Price = (decimal)23094.0,
                Currency = "COP"
            };

            //Act
            //var result = ModelState;
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(model, new ValidationContext(model), validationResults, true);


            //Assert
            Assert.False(actual, "Expected validation to fail.");
        }
    }
}
