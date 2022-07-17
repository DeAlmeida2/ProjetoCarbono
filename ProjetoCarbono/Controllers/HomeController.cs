using Microsoft.AspNetCore.Mvc;
using ProjetoCarbono.Models;
using System.Diagnostics;

namespace ProjetoCarbono.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Transporte = "Veículo  - Flex";
            home.ConsumoVeiculo = "9";
            home.Passageiros = "1";
            home.Emissão = "1,1780";

            return View(home);  
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