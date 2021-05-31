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
    public class OpticalDriveController : ControllerBase
    {
        [ApiController]
        [Route("[controller]")]
        private readonly OpticalDriveService _dataFromService;

        public OpticalDriveController(OpticalDriveService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<OpticalDrive> Get(){
            return _dataFromService.getOpticalDrives();
        }

        [HttpGet("byid/{id}")]
        public OpticalDrive GetOpticalDriveById([FromRoute] int id){
            return _dataFromService.GetOpticalDriveById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] OpticalDrive input)
        {
            return _dataFromService.addOpticalDrive(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] OpticalDrive input)
        {
            return _dataFromService.updateOpticalDrive(input);
        }

        [HttpDelete("delete")]
        public bool deleteOpticalDrive([FromBody] OpticalDrive input)
        {
            return _dataFromService.deleteOpticalDrive(input);
        }
    }
}