using CustomersWebApi.DataAccess;
using CustomersWebApi.Dtos;
using CustomersWebApi.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CustomersWebApi.Controllers
{
    [Controller]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerContext _context;
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(CustomerContext context, ILogger<CustomersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("customers")]
        public ActionResult<CustomerDto> Get(int startIndex, int size)
        {
            return Ok(_context
                .Customers
                .Skip(startIndex)
                .Take(size)
                .OrderBy(c => c.CompanyName)
                .ToList()
                .Select(c => c.AsDto()));
        }
    }
}