using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class HardDriveService
    {
        private readonly DataContext _dataFromService;
        public HardDriveService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<HardDrive> getHardDrives()
        {
            return _dataFromService.HardDrives;
        }

        public HardDrive GetHardDriveById(int id)
        {
            return _dataFromService.HardDrives
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addHardDrive(HardDrive input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateHardDrive(HardDrive input)
        {
            _dataFromService.HardDrives.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteHardDrive(HardDrive input)
        {
            _dataFromService.HardDrives.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}