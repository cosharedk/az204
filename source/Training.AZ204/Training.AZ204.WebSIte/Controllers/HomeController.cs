using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Training.AZ204.WebSIte.Models;

namespace Training.AZ204.WebSIte.Controllers
{
    public class HomeController : Controller
    {

        private TelemetryClient telemetryClient = new TelemetryClient(TelemetryConfiguration.CreateDefault());



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            telemetryClient.TrackPageView("Forsiden");

            DateTime startTime = DateTime.Now;

            System.Threading.Thread.Sleep(5000);

            DateTime endTime = DateTime.Now;

            TimeSpan timeSpan = endTime - startTime;

            telemetryClient.TrackMetric("DetTogTid", timeSpan.Seconds);

            try
            {
                string[] numbers = { "One", "Two" };
                string number = numbers[2];
            }
            catch (Exception ex)
            {
                telemetryClient.TrackException(ex);
                
            }

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
