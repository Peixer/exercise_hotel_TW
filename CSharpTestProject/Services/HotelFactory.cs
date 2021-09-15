using CSharpTestProject.Domain;

namespace CSharpTestProject.Services
{
    public class HotelFactory
    {
        public Hotel Create(string name, int classification, decimal priceWeekRegular,
            decimal priceWeekFidelidade, decimal priceWeekendRegular, decimal priceWeekendFidelidade)
        {
            return new Hotel(name, classification, priceWeekRegular, priceWeekFidelidade, priceWeekendRegular,
                priceWeekendFidelidade);
        }
    }
}