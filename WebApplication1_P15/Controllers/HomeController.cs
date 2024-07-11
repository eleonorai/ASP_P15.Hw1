//using ASP_P15.Models;
using ASP_P15.Services.Hash;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1_P15.Models;
using ASP_P15.Services.Hash;
using ASP_P15.Services.OTP;
using ASP_P15.Services.FileName;

namespace ASP_P15.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        
        private readonly IHashService _hashService;

        private readonly IOtpService _otpService;

        private readonly IFileNameService _fileNameService;

        public HomeController(ILogger<HomeController> logger, IHashService hashService, IOtpService otpService, IFileNameService fileNameService)
        {
            _logger = logger;
            _hashService = hashService;
            _otpService = otpService;
            _fileNameService = fileNameService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }

        public IActionResult UrlStructure()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }
        public IActionResult Ioc()
        {
            ViewData["hash"] = _hashService.Digest("123");
            ViewData["hashCode"] = _hashService.GetHashCode();
            ViewData["password"] = _otpService.GeneratePassword();
            ViewData["lowerCaseFileName"] = _fileNameService.GenerateRandomFileName(12);
            ViewData["upperCaseFileName"] = _fileNameService.GenerateRandomFileName(12, true);
            ViewData["numbersFileName"] = _fileNameService.GenerateRandomFileName(12, false, true);
            return View();
        }

        public IActionResult SignUp()
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