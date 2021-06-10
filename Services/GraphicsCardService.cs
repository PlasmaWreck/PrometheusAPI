using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        public IEnumerable<GraphicsCard> getGraphicsCards()
        {
            return _dataFromService.GraphicsCards;
        }

        public GraphicsCard GetGraphicsCardById(int id)
        {
            return _dataFromService.GraphicsCards
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addGraphicsCard(GraphicsCard card)
        {
            _dataFromService.Add(card);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateGraphicsCard(GraphicsCard card)
        {
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
        public List<GraphicsCard> getRange(double price)
        {
            var startingList = _dataFromService.GraphicsCards.ToList();

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
                return _dataFromService.GraphicsCards
                .Where(x => x.Id == priceList[priceList.Count - 1].Id || x.Id == priceList[priceList.Count - 2].Id || x.Id == priceList[priceList.Count - 3].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else if(priceList[0].Id == closestRangeSaver.Id)
            {
                return _dataFromService.GraphicsCards
                .Where(x => x.Id == priceList[0].Id || x.Id == priceList[1].Id || x.Id == priceList[2].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }else{
                var test = priceList.IndexOf(nearest);
                return _dataFromService.GraphicsCards
                .Where(x => x.Id == priceList[test].Id || x.Id == priceList[test + 1].Id || x.Id == priceList[test - 1].Id)
                .OrderBy(x => x.Price)
                .ToList();
            }
        }
    }
}