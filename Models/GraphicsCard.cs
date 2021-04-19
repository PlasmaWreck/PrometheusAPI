namespace PrometheusAPI.Models
{
    public class GraphicsCard
    {
        public int Id {get;set;}

        public string Name {get;set;}

        public string GPU {get;set;}

        public int CoreCount {get;set;}

        //Measured in MHz
        public int CoreClockSpeed {get;set;}

        public string MemoryType {get;set;}

        //Measured in GB
        public int MemorySize {get;set;}
        
        //Measured in GB/s
        public int MemoryBandwith {get;set;}

        //Measured in bits
        public int MotherBoardInterface {get;set;}

        //Measured in Watts
        public int ThermalDesignPower {get;set;}

        public string[] PowerConnectors {get;set;}

        public string[] VideoOutputPorts {get;set;}

        public string APISupport {get;set;}
        
        //Measured in teraflops
        public int ComputePerformance {get;set;}
        
    }
}