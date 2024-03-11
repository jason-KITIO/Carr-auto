using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;
        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            this._emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "kanamax00@gmail.com";
            var subject = "Test";
            var message = "Hello World";

            await _emailSender.SendEmailAsync(receiver, subject, message);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
