using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using old_portfolio.Models;

namespace old_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

      public IActionResult Index() //action name/method ... home/Index
        {
            return View();
        }
        [HttpGet]
        [Route("/about/")]
        public IActionResult about()
        {
            return View();
        }
        //attribute based routing
        [HttpGet]
        [Route("/skills/")]
        public IActionResult skills() //action name/method ... home/Index
        {
            return View();
        }
        [HttpGet]
        [Route("/work/")]
        public IActionResult work()
        {
            return View();
        }

        [HttpGet]
        [Route("/Contact_Me/")]
        public IActionResult Contact_Me()
        {
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}