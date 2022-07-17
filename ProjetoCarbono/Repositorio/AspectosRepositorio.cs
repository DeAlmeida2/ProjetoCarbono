using ProjetoCarbono.Data;
using ProjetoCarbono.Models;

namespace ProjetoCarbono.Repositorio
{
    public class AspectosRepositorio : IAspectosRepositorio
    {
        private readonly BancoContext _bancoContext;
        public AspectosRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<AspectosModel> BuscarTodos()
        {
            return _bancoContext.Aspectos.ToList();
        }
        public AspectosModel Adicionar(AspectosModel aspectos)
        {
            _bancoContext.Aspectos.Add(aspectos);
            _bancoContext.SaveChanges();
            return aspectos;
        }

        
    }
}
