using ProjetoCarbono.Models;

namespace ProjetoCarbono.Repositorio
{
    public interface IAspectosRepositorio
    {
        List<AspectosModel> BuscarTodos();    
        AspectosModel Adicionar(AspectosModel aspectos);
    }
}
