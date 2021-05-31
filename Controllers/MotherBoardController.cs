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
    public class MotherBoardController : ControllerBase
    {
        private readonly MotherBoardService _dataFromService;

        public MotherBoardController(MotherBoardService dataFromService)
        {
            _dataFromService = dataFromService;
        }

        [HttpGet, AllowAnonymous]
        public IEnumerable<MotherBoard> Get(){
            return _dataFromService.getMotherBoards();
        }

        [HttpGet("byid/{id}")]
        public MotherBoard GetMotherBoardById([FromRoute] int id){
            return _dataFromService.GetMotherBoardById(id);
        }
        
        [HttpPost("add")]
        public bool Add([FromBody] MotherBoard input)
        {
            return _dataFromService.addMotherBoard(input);
        }

        [HttpPut("update")]
        public bool UpdateId([FromBody] MotherBoard input)
        {
            return _dataFromService.updateMotherBoard(input);
        }

        [HttpDelete("delete")]
        public bool deleteMotherBoard([FromBody] MotherBoard input)
        {
            return _dataFromService.deleteMotherBoard(input);
        }
    }
}