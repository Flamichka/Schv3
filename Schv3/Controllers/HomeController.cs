using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schv3.Data;
using Schv3.Models;
using Schv3.Query;
using System.Diagnostics;
using System.Linq;

namespace Schv3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        //METHOD TO DISPLAY RANDOM SHIT ON A PAGE
        public IActionResult MainPage()
        {/*
            Test test = new Test();
            test.create();
            var db = new AppDataDbContext { };
            var query = db.Groups;
            */
            //EditorQueries.CreateAny(x);
            return View(/*query*/);
        }

        public IActionResult Index()
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