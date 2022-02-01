using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission04.Models;

namespace Mission04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // reference context file
        private MoviesContext GenContext { get; set; }

        // create home controller
        public HomeController(ILogger<HomeController> logger, MoviesContext MovieEntry)
        {
            _logger = logger;
            GenContext = MovieEntry;
        }

        // call index page
        public IActionResult Index()
        {
            return View();
        }

        // call podcast lists
        public IActionResult MyPodcasts()
        {
            return View();
        }

        // call the add movie form
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // submit the contents (ar) of the form and redirect to a confirmation page
        [HttpPost]
        public IActionResult AddMovie(ApplicationResponse ar)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                GenContext.Add(ar);
                GenContext.SaveChanges();
                return View("Confirmation", ar);
            }
        }

        // calls privacy page, may remove
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
