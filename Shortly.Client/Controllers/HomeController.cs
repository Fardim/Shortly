using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;
using Shortly.Client.Data.ViewModels;

namespace Shortly.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(new PostUrlVM());
        }

        public IActionResult ShortenUrl(PostUrlVM postUrlVM)
        {
            return RedirectToAction("Index");
        }
    }
}
