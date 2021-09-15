using System;
using System.Collections.Generic;
using System.Linq;
using CSharpTestProject.Domain;

namespace CSharpTestProject.Services
{
    public class CalculateService
    {
        public HotelResult Calculate(ClientType clientType, DateTime[] dates)
        {
            HotelFactory hotelFactory = new HotelFactory();
            List<HotelResult> hotelResults = new List<HotelResult>();
            List<Hotel> hotels = new List<Hotel>();
            hotels.Add(hotelFactory.Create("Parque das flores", 3, 110, 80, 90, 80));
            hotels.Add(hotelFactory.Create("Jardim Botânico", 4, 160, 110, 60, 50));
            hotels.Add(hotelFactory.Create("Mar Atlântico", 5, 220, 100, 150, 40));

            foreach (var hotel in hotels)
            {
                var price = CalculatePriceByHotel(hotel, clientType, dates);
                hotelResults.Add(new HotelResult(price, hotel, dates));
            }

            hotelResults.Sort();

            return hotelResults.First();
        }

        private decimal CalculatePriceByHotel(Hotel hotel, ClientType clientType, DateTime[] dates)
        {
            decimal price = 0;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    price += clientType == ClientType.Fidelidade
                        ? hotel.PriceWeekendFidelidade
                        : hotel.PriceWeekendRegular;
                else
                    price += clientType == ClientType.Fidelidade
                        ? hotel.PriceWeekFidelidade
                        : hotel.PriceWeekRegular;
            }

            return price;
        }
    }
}