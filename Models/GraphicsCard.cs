namespace PrometheusAPI.Models
{
    public class GraphicsCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GPU { get; set; }
        public int CoreCount { get; set; }
        public string CoreClockSpeed { get; set; }
        public string MemoryType { get; set; }
        public string MemorySize { get; set; }
        public string MemorySpeed { get; set; }
        public string MemoryBandwidth { get; set; }
        public string MemoryBus { get; set; }
        public string ThermalDesignPower { get; set; }
        public string SuggestedPSU { get; set; }
        public string VideoOutputPorts { get; set; }
        public string PowerConnectors { get; set; }
        public string ComputePerformance { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }

    }
}