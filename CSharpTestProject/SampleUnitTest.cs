using System;
using CSharpTestProject.Domain;
using CSharpTestProject.Services;
using Xunit;

namespace CSharpTestProject
{
    public class SampleUnitTest
    {
        [Fact]
        public void Test1()
        {
            DateTime[] dates = DateHelper.Convert("16Mar2020(mon)", "17Mar2020(tue)", "18Mar2020(wed)");
            ClientType clientType = ClientType.Regular;
            CalculateService calculateService = new CalculateService();
            var hotelResult = calculateService.Calculate(clientType, dates);
            Assert.Same(hotelResult.Hotel.Name, "Parque das flores");
        }
        
        [Fact]
        public void Test2()
        {
            DateTime[] dates = DateHelper.Convert("20Mar2020(fri)", "21Mar2020(sat)", "22Mar2020(sun)");
            ClientType clientType = ClientType.Regular;
            CalculateService calculateService = new CalculateService();
            var hotelResult = calculateService.Calculate(clientType, dates);
            Assert.Same(hotelResult.Hotel.Name, "Jardim Botânico");
        }
        
        [Fact]
        public void Test3()
        {
            DateTime[] dates = DateHelper.Convert("26Mar2020(thu)", "27Mar2020(fri)", "28Mar2020(sat)");
            ClientType clientType = ClientType.Fidelidade;
            CalculateService calculateService = new CalculateService();
            var hotelResult = calculateService.Calculate(clientType, dates);
            Assert.Same(hotelResult.Hotel.Name, "Mar Atlântico");
        }
    }
}