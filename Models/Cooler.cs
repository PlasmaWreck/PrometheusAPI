namespace PrometheusAPI.Models
{
    public class Cooler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int NumOfFans { get; set; }
        public bool LiquidCooling { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
    }
}