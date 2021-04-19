using System.Collections.Generic;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class GraphicsCardService
    {
        public List<GraphicsCard> GraphicsCardList = new List<GraphicsCard>(){
            new GraphicsCard() { Id = 0, Name = "GeForce GTX 1080", GPU = "NVIDIA", CoreCount = 2560, CoreClockSpeed = 1607, MemoryType = "GDDR5X", MemorySize = 8, MemoryBandwith = 320, MotherBoardInterface = 256, ThermalDesignPower= 180, VideoOutputPorts = new string[] {"Dual Link DVI-I", "HDMI 2.0b","Display Port 1.4","Display Port 1.4","Display Port 1.4"}, PowerConnectors = new string[]{""}, APISupport = "", ComputePerformance = 9}
        };


        public IEnumerable<GraphicsCard> GetGraphicsCards()
        {
            return GraphicsCardList;
        }
    }
}