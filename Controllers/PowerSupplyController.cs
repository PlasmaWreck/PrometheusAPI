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
    
    public class PowerSupplyController : ControllerBase
    {
        private readonly PowerSupplyService _dataFromService;

        public PowerSupplyController(PowerSupplyService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<PowerSupply> Get(){
            return _dataFromService.getPowerSupplies();
        }

        [HttpGet("byid/{id}")]
        public PowerSupply GetPowerSupplyById([FromRoute] int id){
            return _dataFromService.GetPowerSupplyById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] PowerSupply input)
        {
            return _dataFromService.addPowerSupply(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] PowerSupply input)
        {
            return _dataFromService.updatePowerSupply(input);
        }

        [HttpDelete("delete")]
        public bool deletePowerSupply([FromBody] PowerSupply input)
        {
            return _dataFromService.deletePowerSupply(input);
        }

        [HttpGet("getrange/{price}")]
        public List<PowerSupply> getRange([FromRoute] double price)
        {
            return _dataFromService.getRange(price);
        }
    }
}