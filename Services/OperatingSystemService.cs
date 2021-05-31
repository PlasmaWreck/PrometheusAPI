using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class OperatingSystemService
    {
        private readonly DataContext _dataFromService;
        public OperatingSystemService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<OS> getOSs()
        {
            return _dataFromService.OperatingSystems;
        }

        public OS GetOSById(int id)
        {
            return _dataFromService.OperatingSystems
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addOS(OS input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateOS(OS input)
        {
            _dataFromService.OperatingSystems.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteOS(OS input)
        {
            _dataFromService.OperatingSystems.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}