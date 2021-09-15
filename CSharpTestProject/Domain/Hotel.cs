namespace CSharpTestProject.Domain
{
    public class Hotel
    {
        public Hotel(string name, int classification, decimal priceWeekRegular, decimal priceWeekFidelidade,
            decimal priceWeekendRegular, decimal priceWeekendFidelidade)
        {
            Name = name;
            Classification = classification;
            PriceWeekRegular = priceWeekRegular;
            PriceWeekFidelidade = priceWeekFidelidade;
            PriceWeekendRegular = priceWeekendRegular;
            PriceWeekendFidelidade = priceWeekendFidelidade;
        }

        public string Name { get; set; }
        public int Classification { get; set; }
        public decimal PriceWeekRegular { get; set; }
        public decimal PriceWeekFidelidade { get; set; }
        public decimal PriceWeekendRegular { get; set; }
        public decimal PriceWeekendFidelidade { get; set; }
    }
}