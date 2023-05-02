using DAL.DTA.Tamrurs;
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
    public class TamrurimController : ControllerBase
    {
        private readonly ITamrurim _dbStore;
        public TamrurimController(ITamrurim dbStore)
        {
            _dbStore = dbStore;
        }
        [HttpGet]
        [Route("/api/getAllTamrurs")]
        public async Task<ActionResult<Tamrurim>> getAllTamrurs()
        {
            var res = await _dbStore.getAllTamrurs();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("/api/getAllSabjectTamrur")]
        public async Task<ActionResult<Tamrurim>> getAllSabjectTamrur()
        {
            var res = await _dbStore.getAllSabjectTamrur();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("/api/playT")]
        public async Task<ActionResult<Tamrurim>> playT()
        {
            var res = await _dbStore.playT();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
    }
}
