using Microsoft.AspNetCore.Mvc;
using ProjetoCarbono.Models;
using ProjetoCarbono.Repositorio;

namespace ProjetoCarbono.Controllers
{
    public class AspectosController : Controller
    {
        private readonly IAspectosRepositorio _aspectosRepositorio;
        public AspectosController(IAspectosRepositorio aspectosRepositorio)
        {
            _aspectosRepositorio = aspectosRepositorio;
        }
        public IActionResult Index()
        {
            List<AspectosModel> aspectos = _aspectosRepositorio.BuscarTodos();
            return View(aspectos);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(AspectosModel aspectos)
        {
            _aspectosRepositorio.Adicionar(aspectos);
            return RedirectToAction("Index");
        }

    }
}
