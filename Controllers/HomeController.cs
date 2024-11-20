using System.Diagnostics;
using CheckBoxAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckBoxAspNetCore.Controllers
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
            //var model = new ViewModel()
            //{
            //    AcceptTerms = true,
            //    Text = "I Accept The Terms & Conditions.",
            //};
            //return View(model);
            var model = new ViewModel()
            {
                CheckBoxes = new List<CheckBoxOption>
                {
                    new CheckBoxOption()
                    {
                        isChecked = true,
                        Text = "Cricket",
                        value = "Cricket"
                    },
                    new CheckBoxOption()
                    {
                        isChecked = false,
                        Text = "Football",
                        value = "Football"
                    },
                    new CheckBoxOption()
                    {
                        isChecked = false,
                        Text = "Hockey",
                        value = "Hockey"
                    }
                }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ViewModel model)
        {
            return View();
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
