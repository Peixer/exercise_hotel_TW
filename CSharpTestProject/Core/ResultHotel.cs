using System;

namespace CSharpTestProject.Core
{
    public class ResultHotel : IComparable<ResultHotel>
    {
        public ResultHotel(Hotel hotel, int price, DateTime[] dates)
        {
            Hotel = hotel;
            Price = price;
            Dates = dates;
        }
        
        public Hotel Hotel { get; set; }
        public int Price { get; set; }
        public DateTime[] Dates { get; set; }

        public int CompareTo(ResultHotel other)
        {
            if (this.Price < other.Price)
                return -1;
            if(other.Price < this.Price)
                return 1;

            return this.Hotel.Classification > other.Hotel.Classification ? -1 : 1;
        }
    }
}