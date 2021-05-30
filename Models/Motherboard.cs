namespace PrometheusAPI.Models
{
    public class Motherboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string FormFactor { get; set; }
        public string CPUSocket { get; set; }
        public string Chipset { get; set; }
        public string USBPorts { get; set; }
        public string RAMSlots { get; set; }
        public string VideoConnectors { get; set; }
        public string PCIESlots { get; set; }
        public string InBuiltWifi { get; set; }
        public string Sata3Connectors { get; set; }
        public string M2NVMESupport { get; set; }
        public string Price { get; set; }
    }
}