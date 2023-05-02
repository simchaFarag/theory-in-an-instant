using DAL.DTA.Test;
using DAL.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teoria_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestData _dbStore;
        public TestController(ITestData dbStore)
        {
            _dbStore = dbStore;
        }

        [HttpGet]
        [Route("/api/getAllQuestion")]
        public async Task<ActionResult<questionArr>> getAllQuestion()
        {
            var res = await _dbStore.getAllQuestion();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("/api/lern")]
        public async Task<ActionResult<questionArr>> lern()
        {
            var res = await _dbStore.lern();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("/api/endTest")]
        public async Task<ActionResult<questionArr>> endTest(List<endTestDto> test)
        {
            var res = await _dbStore.endTest(test);
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }

    }
}
