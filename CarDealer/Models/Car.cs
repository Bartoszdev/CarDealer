namespace CarDealer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand  { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Mileage { get; set; }
        public string EngineCapacity { get; set; }
        public string Fuel { get; set; }
        public string Power { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UrlPhoto { get; set; }
        public string UrlMiniature { get; set; }
        public bool CarOfTheWeek { get; set; }
        public bool InCentralStock { get; set; }
    }
}
