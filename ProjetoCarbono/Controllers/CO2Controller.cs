using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoCarbono.Models;
using ProjetoCarbono.Repositorio;

namespace ProjetoCarbono.Controllers
{
    public class CO2Controller : Controller
    {
        private readonly IAspectosRepositorio _aspectosRepositorio;
        public CO2Controller(IAspectosRepositorio aspectosRepositorio)
        {
            _aspectosRepositorio = aspectosRepositorio;
        }
        public IActionResult Calculo()
        {
            List<AspectosModel> aspectos = _aspectosRepositorio.BuscarTodos();
            ViewBag.Aspectos = new SelectList(aspectos, "Id", "Transporte");
            return View();
        }
        [HttpPost]
        public IActionResult Calculo(CO2Model co2)
        {
            if (ModelState.IsValid)
            {
                var aspectos = _aspectosRepositorio.ListarPorId(co2.Id);
                co2.Transporte = aspectos.Transporte;
                co2.ConsumoVeiculo = double.Parse(aspectos.ConsumoVeiculo);
                co2.Passageiros = Convert.ToInt16(aspectos.Passageiros);
                co2.Emissão = double.Parse(aspectos.Emissão);

                co2.Calculo = co2.Calculo = (co2.Km / co2.ConsumoVeiculo) * (co2.Emissão / co2.Passageiros)*57;
                co2.Compensacao = (co2.Calculo / 365 * 1.4);
                co2.Credito = (co2.Calculo * 1.54);

                return RedirectToAction(nameof(Calcular(co2)));
            }
            return View(Calcular(co2));

        }
        [HttpGet]
        public IActionResult Calcular (CO2Model co2)
        {
            return View(co2);
        }
    }
}
