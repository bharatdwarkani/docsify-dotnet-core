using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 

namespace DocsWebSite.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public ErrorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        } 

        [Route("error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
