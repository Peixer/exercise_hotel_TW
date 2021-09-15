using System;
using System.Collections.Generic;
using System.Globalization;
using CSharpTestProject.Core;
using CSharpTestProject.Service;
using Xunit;

namespace CSharpTestProject
{
    public class SampleUnitTest
    {
        [Fact]
        public void ShouldFail()
        {
            var calculateService = new CalculatePriceService();
            var dates = DateHelper.Convert("16Mar2020(mon)", "17Mar2020(tue)", "18Mar2020(wed)");

            var hotel = calculateService.Calculate(ClientType.Regular, dates);

            Assert.Same(hotel.Hotel.Name, "Parque das flores");
        }

        [Fact]
        public void ShouldFail2()
        {
            var calculateService = new CalculatePriceService();
            var dates = DateHelper.Convert("20Mar2020(fri)", "21Mar2020(sat)", "22Mar2020(sun)");

            var hotel = calculateService.Calculate(ClientType.Regular, dates);
            Assert.Same(hotel.Hotel.Name, "Jardim Botânico");
        }
    }
}