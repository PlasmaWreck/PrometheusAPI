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
    
    public class OperatingSystemController : ControllerBase
    {
        private readonly OperatingSystemService _dataFromService;

        public OperatingSystemController(OperatingSystemService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<OS> Get(){
            return _dataFromService.getOSs();
        }

        [HttpGet("byid/{id}")]
        public OS GetOperatingSystemById([FromRoute] int id){
            return _dataFromService.GetOSById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] OS input)
        {
            return _dataFromService.addOS(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] OS input)
        {
            return _dataFromService.updateOS(input);
        }

        [HttpDelete("delete")]
        public bool deleteOperatingSystem([FromBody] OS input)
        {
            return _dataFromService.deleteOS(input);
        }

        [HttpGet("getrange/{price}")]
        public List<OS> getRange([FromRoute] double price)
        {
            return _dataFromService.getRange(price);
        }
    }
}