using System.Collections.Generic;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class GraphicsCardService
    {
        private readonly DataContext _dataFromService;
        public GraphicsCardService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public List<GraphicsCard> GraphicsCardList = new List<GraphicsCard>(){
            new GraphicsCard() { Id = 0, Name = "GeForce GTX 1080", GPU = "NVIDIA", CoreCount = 2560, CoreClockSpeed = 1607, MemoryType = "GDDR5X", MemorySize = 8, MemoryBandwith = 320, MotherBoardInterface = 256, ThermalDesignPower= 180, VideoOutputPorts = "", PowerConnectors = "", APISupport = "", ComputePerformance = 9}
        };


        public IEnumerable<GraphicsCard> GetGraphicsCards()
        {
            return _dataFromService.GraphicsCards;
        }
        
        public bool addGraphicsCard(GraphicsCard card)
        {
            _dataFromService.Add(card);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateGraphicsCard(GraphicsCard card){
            _dataFromService.GraphicsCards.Update(card);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteGraphicsCard(GraphicsCard card)
        {
            _dataFromService.GraphicsCards.Remove(card);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}