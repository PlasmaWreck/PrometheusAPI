using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class OpticalDriveService
    {
        private readonly DataContext _dataFromService;
        public OpticalDriveService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<OpticalDrive> getOpticalDrives()
        {
            return _dataFromService.OpticalDrives;
        }

        public OpticalDrive GetOpticalDriveById(int id)
        {
            return _dataFromService.OpticalDrives
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addOpticalDrive(OpticalDrive input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateOpticalDrive(OpticalDrive input)
        {
            _dataFromService.OpticalDrives.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteOpticalDrive(OpticalDrive input)
        {
            _dataFromService.OpticalDrives.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}