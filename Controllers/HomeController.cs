using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationFilterTest.Models;

namespace ValidationFilterTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok("Hello World"));
        }

        [HttpPost]
        public Task<IActionResult> Post([FromBody] CreateContactRequest contactRequest)
        {
            return Task.FromResult<IActionResult>(Ok("Hello World"));
        }
    }
}
