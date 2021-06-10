using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class CaseService
    {
        private readonly DataContext _dataFromService;
        public CaseService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<Case> getCases()
        {
            return _dataFromService.Cases.ToList();
        }

        public Case GetCaseById(int id)
        {
            return _dataFromService.Cases
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addCase(Case test)
        {
            _dataFromService.Add(test);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateCase(Case test)
        {
            _dataFromService.Cases.Update(test);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteCase(Case test)
        {
            _dataFromService.Cases.Remove(test);
            _dataFromService.SaveChanges();
            return true;
        }

        public List<Case> getRange(double price)
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
                return _dataFromService.Cases
                .Where(x => x.Id == priceList[priceList.Count - 1].Id || x.Id == priceList[priceList.Count - 2].Id || x.Id == priceList[priceList.Count - 3].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else if(priceList[0].Id == closestRangeSaver.Id)
            {
                return _dataFromService.Cases
                .Where(x => x.Id == priceList[0].Id || x.Id == priceList[1].Id || x.Id == priceList[2].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else{
                var test = priceList.IndexOf(nearest);
                return _dataFromService.Cases
                .Where(x => x.Id == priceList[test].Id || x.Id == priceList[test + 1].Id || x.Id == priceList[test - 1].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }
        }
    }
}