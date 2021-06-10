using System;
using System.Collections.Generic;
using System.Linq;
using PrometheusAPI.Models;
using PrometheusAPI.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace PrometheusAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoolerController : ControllerBase
    {
        private readonly CoolerService _dataFromService;

        public CoolerController(CoolerService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<Cooler> Get(){
            return _dataFromService.getCoolers();
        }

        [HttpGet("byid/{id}")]
        public Cooler GetCoolerById([FromRoute] int id){
            return _dataFromService.GetCoolerById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] Cooler input)
        {
            return _dataFromService.addCooler(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] Cooler input)
        {
            return _dataFromService.updateCooler(input);
        }

        [HttpDelete("delete")]
        public bool deleteCooler([FromBody] Cooler input)
        {
            return _dataFromService.deleteCooler(input);
        }

        [HttpPost("getrange/{price}")]
        public List<Cooler> getRange([FromRoute] double price)
        {
            return _dataFromService.getRange(price);
        }
    }
}