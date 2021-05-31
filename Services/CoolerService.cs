using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class CoolerService
    {
        private readonly DataContext _dataFromService;
        public CoolerService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<Cooler> getCoolers()
        {
            return _dataFromService.Coolers;
        }

        public Cooler GetCoolerById(int id)
        {
            return _dataFromService.Coolers
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addCooler(Cooler input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateCooler(Cooler input)
        {
            _dataFromService.Coolers.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteCooler(Cooler input)
        {
            _dataFromService.Coolers.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}