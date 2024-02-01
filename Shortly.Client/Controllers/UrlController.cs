using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            var url = new Url
            {
                Id = 1,
                OriginalLink = "http://google.com",
                ShortLink = "shrtly",
                NrOfClicks = 1,
                UserId = 1,
            };
            var allData = new List<Url>();
            allData.Add(url);
            return View(allData);
        }
    }
}
