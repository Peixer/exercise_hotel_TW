using System;
using System.Collections.Generic;
using System.Linq;
using CSharpTestProject.Core;

namespace CSharpTestProject.Service
{
    public class CalculatePriceService
    {
        public ResultHotel Calculate(ClientType clientType, params DateTime[] dates)
        {
            var hotelResult = new List<ResultHotel>();

            var hotels = new List<Hotel>()
            {
                new FloresHotel(),
                new JardimHotel(),
                new AtlanticoHotel()
            };

            foreach (var hotel in hotels)
                hotelResult.Add(hotel.CalculateDate(clientType, dates));

            hotelResult.Sort();

            return hotelResult.First();
        }
        
        public ResultHotel CalculateDate(IHotel hotel, ClientType clientType, params DateTime[] dates)
        {
            var price = 0;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    price += clientType == ClientType.Fidelidade ? hotel.FidelidadeWeekend : hotel.RegularWeekend;
                else
                    price += clientType == ClientType.Fidelidade ? hotel.FidelidadeWeek : hotel.RegularWeek;
            }

            return new ResultHotel(this, price, dates);
        }
    }
}