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

        [HttpGet ,Authorize]
        public IEnumerable<GraphicsCard> GetGraphicsCards(){
            return _dataFromService.GetGraphicsCards();
        }
        
    }
}