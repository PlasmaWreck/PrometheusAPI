using System;
using System.Collections.Generic;
using System.Globalization;
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

        public List<HardDrive> getRange(double price)
        {
            var startingList = _dataFromService.Cases.ToList();

            var priceList = startingList
            .Select(x => new RangeSaver
            {
                Id = x.Id,
                Price = Convert.ToDouble(x.Price.Substring(1), CultureInfo.InvariantCulture)
            })
            .OrderBy(x => x.Price)
            .ToList();

            var nearest = priceList.OrderBy(x => Math.Abs(x.Price - price)).First();

            var closestRangeSaver = priceList.SingleOrDefault(x => nearest.Price == x.Price);

            if(priceList[priceList.Count - 1].Id == closestRangeSaver.Id)
            {
                return _dataFromService.HardDrives
                .Where(x => x.Id == priceList[priceList.Count - 1].Id || x.Id == priceList[priceList.Count - 2].Id || x.Id == priceList[priceList.Count - 3].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else if(priceList[0].Id == closestRangeSaver.Id)
            {
                return _dataFromService.HardDrives
                .Where(x => x.Id == priceList[0].Id || x.Id == priceList[1].Id || x.Id == priceList[2].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else{
                var test = priceList.IndexOf(nearest);
                return _dataFromService.HardDrives
                .Where(x => x.Id == priceList[test].Id || x.Id == priceList[test + 1].Id || x.Id == priceList[test - 1].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }
        }
    }
}