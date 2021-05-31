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
    
    public class CaseController : ControllerBase
    {
        private readonly CaseService _dataFromService;

        public CaseController(CaseService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<Case> Get(){
            return _dataFromService.getCases();
        }

        [HttpGet("byid/{id}")]
        public Case GetCaseById([FromRoute] int id){
            return _dataFromService.GetCaseById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] Case input)
        {
            return _dataFromService.addCase(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] Case input)
        {
            return _dataFromService.updateCase(input);
        }

        [HttpDelete("delete")]
        public bool deleteCase([FromBody] Case input)
        {
            return _dataFromService.deleteCase(input);
        }
    }
}