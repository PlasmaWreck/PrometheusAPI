using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class ProcessorService
    {
        private readonly DataContext _dataFromService;
        public ProcessorService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<Processor> getProcessors()
        {
            return _dataFromService.Processors;
        }

        public IEnumerable<Processor> searchProcessors(string search)
        {
            return _dataFromService.Processors.Where(p => p.Id.ToString() == search);
        }
        
        public bool addProcessor(Processor chip)
        {
            _dataFromService.Processors.Add(chip);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateProcessor(Processor chip)
        {
            _dataFromService.Processors.Update(chip);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteProcessor(Processor chip)
        {
            _dataFromService.Processors.Remove(chip);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}