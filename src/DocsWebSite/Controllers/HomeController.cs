using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 

namespace DocsWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Home()
        {
            return LocalRedirect("/docs");
        }


        [Route("docs")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
