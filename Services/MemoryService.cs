using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Context;
using PrometheusAPI.Models;
using PrometheusAPI.Services;

namespace PrometheusAPI.Services
{
    public class MemoryService
    {
        private readonly DataContext _dataFromService;
        public MemoryService(DataContext dataFromService)
        {
            _dataFromService = dataFromService;
        }
        public IEnumerable<Memory> getMemories()
        {
            return _dataFromService.Memories;
        }

        public Memory GetMemoryById(int id)
        {
            return _dataFromService.Memories
            .SingleOrDefault(p => p.Id == id);
        }
        
        public bool addMemory(Memory input)
        {
            _dataFromService.Add(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool updateMemory(Memory input)
        {
            _dataFromService.Memories.Update(input);
            _dataFromService.SaveChanges();
            return true;
        }

        public bool deleteMemory(Memory input)
        {
            _dataFromService.Memories.Remove(input);
            _dataFromService.SaveChanges();
            return true;
        }
    }
}