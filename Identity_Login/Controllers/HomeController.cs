using Identity_Login.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Identity_Login.Controllers
{
    // Adicionando AUTORIZAÇÃO no HomeController
    // Significa que somente USUÁRIOS LOGADOS poderão acessar esse CONTROLLER.
    //[Authorize]
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

        // Também podemos optar por AUTORIZAR somente ACTIONS, assim o usuário conseguirá acessar o CONTROLLER e algumas ACTIONS, mas não todas as actions.
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyMethod(string parameter)
        {
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}