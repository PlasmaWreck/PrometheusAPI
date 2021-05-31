namespace PrometheusAPI.Models
{
    public class MotherBoard
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
        public bool InBuiltWifi { get; set; }
        public string Sata3Connectors { get; set; }
        public bool M2NVMESupport { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
    }
}