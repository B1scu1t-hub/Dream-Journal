using Microsoft.AspNetCore.Mvc;

namespace C_WebAPI_1.Controllers
{
    [ApiController]
    [Route("")]
    public class HomePageController : Controller
    {
        [HttpGet(Name ="HomePage")]
        public string PlaceHolder()
        {
            return "Welcome to the homepage!";
        }
    }
}
