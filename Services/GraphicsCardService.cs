using System;
using System.Collections.Generic;
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

        public IEnumerable<GraphicsCard> searchGraphicsCardsById(string search)
        {
            return _dataFromService.GraphicsCards.Where(p => p.Id.ToString() == search);
        }
        public IEnumerable<GraphicsCard> searchGraphicsCardsByName(string search)
        {
            return _dataFromService.GraphicsCards.Where(p => p.Name.ToLower().Contains(search.Trim().ToLower()));
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
    }
}