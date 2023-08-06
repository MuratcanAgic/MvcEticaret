using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<ProductItem> _products = new List<ProductItem>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _products.AddRange(new List<ProductItem> {
                new ProductItem { Id = 1, imageUrl = "../images/mouse.png", isSale= true, OldPrice=20.50m, Price=15.00m, StartCount=3, Title="Mouse" },
                new ProductItem { Id = 2, imageUrl = "../images/keyboard.png", isSale= false, OldPrice=30.00m, Price=30.00m, StartCount=5, Title="Keyboard" },
                new ProductItem { Id = 3, imageUrl = "../images/ram.jpg", isSale= true, OldPrice=14.99m, Price=12.00m, StartCount=0, Title="Ram" },
                new ProductItem { Id = 4, imageUrl = "../images/ssd.png", isSale= false, OldPrice=25.00m, Price=25.00m, StartCount=4, Title="SSD" },
                new ProductItem { Id = 5, imageUrl = "../images/processor.png", isSale= true, OldPrice=155.99m, Price=140.50m, StartCount=2, Title="Processor" },
                new ProductItem { Id = 6, imageUrl = "../images/headphone.png", isSale= false, OldPrice=28.00m, Price=28.00m, StartCount=5, Title="Headphone" },
                new ProductItem { Id = 7, imageUrl = "../images/monitor.png", isSale= true, OldPrice=132.00m, Price=110.00m, StartCount=0, Title="Monitor" },
                new ProductItem { Id = 8, imageUrl = "../images/graphicCard.png", isSale= false, OldPrice=430.00m, Price=430.00m, StartCount=5, Title="Graph Card" }
            });
            return View(_products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}