using ProjetoCarbono.Models;

namespace ProjetoCarbono.Repositorio
{
    public interface IAspectosRepositorio
    {
        AspectosModel ListarPorId(int id);
        List<AspectosModel> BuscarTodos();    
        AspectosModel Adicionar(AspectosModel aspectos);
        AspectosModel Atualizar(AspectosModel aspectos);
        bool Apagar(int Id);
    }
}
