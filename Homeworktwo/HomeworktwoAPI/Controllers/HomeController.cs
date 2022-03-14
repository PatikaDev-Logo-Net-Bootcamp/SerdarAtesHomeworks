using Microsoft.AspNetCore.Mvc;


namespace HomeworktwoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/json")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
      
            return Ok();
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login()
        {
            return Ok();
        }
  
        [HttpPost]
        [Route("Register")]
        public IActionResult Register()
        {
            return Ok();
        }
        
        [HttpDelete]
        [Route("Hidden")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Hidden()
        {
            return Ok();
        }


    }
  
}
