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
    public class MemoryController : ControllerBase
    {
        private readonly MemoryService _dataFromService;

        public MemoryController(MemoryService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<Memory> Get(){
            return _dataFromService.getMemories();
        }

        [HttpGet("byid/{id}")]
        public Memory GetMemoryById([FromRoute] int id){
            return _dataFromService.GetMemoryById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] Memory input)
        {
            return _dataFromService.addMemory(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] Memory input)
        {
            return _dataFromService.updateMemory(input);
        }

        [HttpDelete("delete")]
        public bool deleteMemory([FromBody] Memory input)
        {
            return _dataFromService.deleteMemory(input);
        }

        [HttpGet("getrange/{price}")]
        public List<Memory> getRange([FromRoute] double price)
        {
            return _dataFromService.getRange(price);
        }
    }
}