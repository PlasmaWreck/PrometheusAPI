using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class PowerSupplyService
    {
        private readonly DataContext _dataFromService;
        public PowerSupplyService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<PowerSupply> getPowerSupplies()
        {
            return _dataFromService.PowerSupplies;
        }

        public PowerSupply GetPowerSupplyById(int id)
        {
            return _dataFromService.PowerSupplies
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addPowerSupply(PowerSupply input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updatePowerSupply(PowerSupply input)
        {
            _dataFromService.PowerSupplies.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deletePowerSupply(PowerSupply input)
        {
            _dataFromService.PowerSupplies.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}