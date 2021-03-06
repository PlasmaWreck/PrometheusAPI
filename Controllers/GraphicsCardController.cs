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
        private readonly GraphicsCardService _dataFromService;

        public GraphicsCardController(GraphicsCardService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet]
        public IEnumerable<GraphicsCard> Get(){
            return _dataFromService.getGraphicsCards();
        }

        [HttpPost, Route("add")]
        public bool Add(GraphicsCard card)
        {
            return _dataFromService.addGraphicsCard(card);
        }

        [HttpPut, Route("update")]
        public bool UpdateId([FromBody] GraphicsCard card)
        {
            return _dataFromService.updateGraphicsCard(card);
        }

        [HttpDelete, Route("delete")]
        public bool deleteGraphicsCard(GraphicsCard card)
        {
            return _dataFromService.deleteGraphicsCard(card);
        }
    }
}