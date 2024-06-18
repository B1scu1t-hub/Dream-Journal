using C_WebAPI_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace C_WebAPI_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BiscuitsController : Controller
    {
        private readonly BiscuitService _biscuitService;

        public BiscuitsController(BiscuitService biscuitService)
        {
            _biscuitService = biscuitService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(Name = "GetBiscuits")]
        public string Get()
        {
            return "Hello Biscuit";
        }

        [HttpGet("types", Name = "GetBiscuitTypes")]
        public IEnumerable<string> GetBiscuitTypes()
        {
            return _biscuitService.GetBiscuitTypes();
        }

    }

        
}
