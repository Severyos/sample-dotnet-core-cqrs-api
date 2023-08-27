using Microsoft.AspNetCore.Mvc;
using System;

namespace SampleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // Andra metoder...

        [HttpGet("random")]
        public IActionResult GetRandomCustomer()
        {
            var randomCustomer = new CustomerDto { Id = Guid.NewGuid() };
            return Ok(randomCustomer);
        }
    }
}
