using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;
using Shortly.Client.Data.ViewModels;

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            var url = new GetUrlVM
            {
                Id = 1,
                OriginalLink = "http://google.com",
                ShortLink = "shrtly",
                NrOfClicks = 1,
                UserId = 1,
            };
            var allData = new List<GetUrlVM>();
            allData.Add(url);
            return View(allData);
        }

    }
}
