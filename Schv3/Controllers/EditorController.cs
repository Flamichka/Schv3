using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schv3.Models;
using System.Diagnostics;

namespace Schv3.Controllers
{
    public class EditorController : Controller
    {
        private readonly ILogger<EditorController> _logger;

        public EditorController(ILogger<EditorController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        //METHOD TO DISPLAY RANDOM SHIT ON A PAGE
        public IActionResult Editor()
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
