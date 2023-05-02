using DAL.DTA.Login;
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
    public class UsersController : ControllerBase
    {
        private readonly ILogin _dbStore;
        public UsersController(ILogin dbStore)
        {
            _dbStore = dbStore;
        }
        [HttpPost]
        [Route("/api/addUser")]
        public async Task<ActionResult<bool>> addUser(alluser user)
        {
            var res = await _dbStore.addUser(user);
            if (res == true)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("/api/getAllUsers")]
        public async Task<ActionResult<alluser>> getAllUsers()
        {
            var res = await _dbStore.getAllUser();
            if (res == null)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("/api/login/{email}")]
        public async Task<ActionResult<alluser>> login(string email)
        {
            var res = await _dbStore.login(email);
            if (res ==1)
            {
                return Ok(res);
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("/api/sendGmail")]
        public async Task<ActionResult<bool>> sendGmail(string userGmail)
        {
            var res = true;
            if (res == true)
            {
                return Ok(res);
            }
            return BadRequest();
        }


    }
}
