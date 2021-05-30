namespace PrometheusAPI.Models
{
    public class PowerSupply
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Efficiency { get; set; }
        public string Power { get; set; }
        public string MainConnectorType { get; set; }
        public bool Modular { get; set; }
        public string Price { get; set; }
    }
}