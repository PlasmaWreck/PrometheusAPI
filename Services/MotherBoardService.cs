using System;
using System.Collections.Generic;
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
    }
}