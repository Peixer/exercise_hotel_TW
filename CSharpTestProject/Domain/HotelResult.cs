using System;

namespace CSharpTestProject.Domain
{
    public class HotelResult : IComparable<HotelResult>
    {
        public HotelResult(decimal price, Hotel hotel, DateTime[] dates)
        {
            Price = price;
            Hotel = hotel;
            Dates = dates;
        }

        public decimal Price { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime[] Dates { get; set; }

        public int CompareTo(HotelResult other)
        {
            if (this.Price < other.Price) return -1;
            if (other.Price < this.Price) return 1;

            return this.Hotel.Classification > other.Hotel.Classification ? -1 : 1;
        }
    }
}