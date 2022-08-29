using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicDataModeling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelingController : ControllerBase
    {
        private readonly ILogger<ModelingController> _logger;
        private readonly DataModelingContext _context;

        public ModelingController(ILogger<ModelingController> logger, DataModelingContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Contacts);
        }

    }
}
