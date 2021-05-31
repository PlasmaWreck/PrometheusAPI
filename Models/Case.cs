namespace PrometheusAPI.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string MBFormFactor { get; set; }
        public bool RGB { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
    }
}