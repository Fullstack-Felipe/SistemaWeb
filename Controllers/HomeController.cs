using Microsoft.AspNetCore.Mvc;
using SiteWebV.Models;
using System.Diagnostics;

namespace SiteWebV.Controllers
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
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Perfil()
        {
            return View();
        }
        public IActionResult Produtos()
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
