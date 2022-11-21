using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schv3.Models;
using System.Diagnostics;

namespace Schv3.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        //METHOD TO DISPLAY RANDOM SHIT ON A PAGE
        public IActionResult Teacher()
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
