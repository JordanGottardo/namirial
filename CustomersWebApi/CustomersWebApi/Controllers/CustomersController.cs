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
        public ActionResult<CustomerDto> Get(int page, int pageSize)
        {
            _logger.LogInformation($"Received request page={page} pageSize={pageSize}");

            //return Ok(_context
            //    .Customers
            //    .Skip(0 * page)
            //    .Take(pageSize)
            //    .OrderBy(c => c.CompanyName)
            //    .ToList()
            //    .Select(c => c.AsDto()));

            return Ok(_context
                .Customers
                .OrderBy(c => c.CompanyName)
                .ToList()
                .Select(c => c.AsDto()));
        }
    }
}