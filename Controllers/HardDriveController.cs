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
    public class HardDriveController : ControllerBase
    {
        private readonly HardDriveService _dataFromService;

        public HardDriveController(HardDriveService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<HardDrive> Get(){
            return _dataFromService.getHardDrives();
        }

        [HttpGet("byid/{id}")]
        public HardDrive GetHardDriveById([FromRoute] int id){
            return _dataFromService.GetHardDriveById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] HardDrive input)
        {
            return _dataFromService.addHardDrive(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] HardDrive input)
        {
            return _dataFromService.updateHardDrive(input);
        }

        [HttpDelete("delete")]
        public bool deleteHardDrive([FromBody] HardDrive input)
        {
            return _dataFromService.deleteHardDrive(input);
        }
    }
}