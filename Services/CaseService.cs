using System;
using System.Collections.Generic;
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
    }
}