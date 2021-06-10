using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class MotherBoardService
    {
        private readonly DataContext _dataFromService;
        public MotherBoardService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<MotherBoard> getMotherBoards()
        {
            return _dataFromService.MotherBoards;
        }

        public MotherBoard GetMotherBoardById(int id)
        {
            return _dataFromService.MotherBoards
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addMotherBoard(MotherBoard input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateMotherBoard(MotherBoard input)
        {
            _dataFromService.MotherBoards.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteMotherBoard(MotherBoard input)
        {
            _dataFromService.MotherBoards.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public List<MotherBoard> getRange(double price)
        {
            var startingList = _dataFromService.MotherBoards.ToList();

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
                return _dataFromService.MotherBoards
                .Where(x => x.Id == priceList[priceList.Count - 1].Id || x.Id == priceList[priceList.Count - 2].Id || x.Id == priceList[priceList.Count - 3].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else if(priceList[0].Id == closestRangeSaver.Id)
            {
                return _dataFromService.MotherBoards
                .Where(x => x.Id == priceList[0].Id || x.Id == priceList[1].Id || x.Id == priceList[2].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else{
                var test = priceList.IndexOf(nearest);
                return _dataFromService.MotherBoards
                .Where(x => x.Id == priceList[test].Id || x.Id == priceList[test + 1].Id || x.Id == priceList[test - 1].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }
        }
    }
}