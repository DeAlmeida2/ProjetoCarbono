using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Editar(int Id)
        {
            AspectosModel aspectos = _aspectosRepositorio.ListarPorId(Id);
            return View(aspectos);
        }
        public IActionResult ApagarConfirmacao(int Id)
        {
            AspectosModel aspectos = _aspectosRepositorio.ListarPorId(Id);
            return View(aspectos);
        }

        public IActionResult Apagar(int Id)
        {
            _aspectosRepositorio.Apagar(Id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Criar(AspectosModel aspectos)
        {
            _aspectosRepositorio.Adicionar(aspectos);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(AspectosModel aspectos)
        {
            _aspectosRepositorio.Atualizar(aspectos);
            return RedirectToAction("Index");
        }

    }
}
