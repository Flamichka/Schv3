using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schv3.Models;
using SQLitePCL;
using System.Diagnostics;
using System.Runtime.Serialization.DataContracts;

namespace Schv3.Controllers
{
    public class ScheduleController : Controller
    {
        public string cMyValue = "some string here";


 

        private readonly ILogger<ScheduleController> _logger;

        public ScheduleController(ILogger<ScheduleController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult Teacher()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            int test = 10;
            return View(test);
            
        }

        public IActionResult Search()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //testout
        

    }
}
