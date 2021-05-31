namespace PrometheusAPI.Models
{
    public class Processor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int CoreCount { get; set; }
        public int ThreadCount { get; set; }
        public string Transistors { get; set; }
        public string Frequency { get; set; }
        public string BaseClock { get; set; }
        public string PCIExpress { get; set; }
        public string Socket { get; set; }
        public string MaxTemp { get; set; }
        public string IntegratedGraphics { get; set; }
        public string MemorySupport { get; set; }
        public string ThermalDesignPower { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
    }
}