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

    public class ProcessorController : ControllerBase
    {
        private readonly ProcessorService _dataFromService;

        public ProcessorController(ProcessorService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<Processor> Get(){
            return _dataFromService.getProcessors();
        }

        [HttpGet("byId/{id}")]
        public Processor GetProcessorById([FromRoute] int id){
            return _dataFromService.GetProcessorById(id);
        }
        
        [HttpPost("add")]
        public bool Add(Processor chip)
        {
            return _dataFromService.addProcessor (chip);
        }

        [HttpPut("update/{id}/{newprice}")]
        public bool UpdateId([FromRoute] int id, [FromRoute] string newPrice)
        {
            return _dataFromService.updatePrice(id,newPrice);
        }

        [HttpDelete("delete")]
        public bool deleteProcessor(Processor chip)
        {
            return _dataFromService.deleteProcessor (chip);
        }

        [HttpGet("getrange/{price}")]
        public List<Processor> getRange([FromRoute] double price)
        {
            return _dataFromService.getRange(price);
        }
    }
}