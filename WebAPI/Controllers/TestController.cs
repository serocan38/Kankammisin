using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TestController : ControllerBase
    {
        private ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("getall")]
        [EnableCors("sero")]

        //   [Authorize(Roles = "Product.List")]

        public IActionResult GetList()
        {
            var result = _testService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest("olmadı");
        }

    }
}
