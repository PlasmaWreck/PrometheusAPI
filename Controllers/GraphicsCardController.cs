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

    public class GraphicsCardController : ControllerBase
    {
        private readonly HardDriveService _dataFromService;

        public GraphicsCardController(HardDriveService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<GraphicsCard> Get(){
            return _dataFromService.getGraphicsCards();
        }

        [HttpGet("byid/{id}")]
        public GraphicsCard GetGraphicsCardById([FromRoute] int id){
            return _dataFromService.GetGraphicsCardById(id);
        }
        
        [HttpPost("add")]
        public bool Add(GraphicsCard card)
        {
            return _dataFromService.addGraphicsCard(card);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] GraphicsCard card)
        {
            return _dataFromService.updateGraphicsCard(card);
        }

        [HttpDelete("delete")]
        public bool deleteGraphicsCard(GraphicsCard card)
        {
            return _dataFromService.deleteGraphicsCard(card);
        }
    }
}