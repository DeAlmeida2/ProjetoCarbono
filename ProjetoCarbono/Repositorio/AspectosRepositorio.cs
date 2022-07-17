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
        public AspectosModel ListarPorId(int id)
        {
            return _bancoContext.Aspectos.FirstOrDefault(x => x.Id == id);
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

        public AspectosModel Atualizar(AspectosModel aspectos)
        {
            AspectosModel aspectosDb = ListarPorId(aspectos.Id);

            if (aspectosDb == null) throw new System.Exception("Houve um erro na atualização do Veículo");
            {
                aspectosDb.Transporte = aspectos.Transporte;
                aspectosDb.ConsumoVeiculo = aspectos.ConsumoVeiculo;
                aspectosDb.Passageiros = aspectos.Passageiros;
                aspectosDb.Emissão = aspectos.Emissão;

                _bancoContext.Aspectos.Update(aspectosDb);
                _bancoContext.SaveChanges();

                return aspectosDb;
            }
        }
    }
}
