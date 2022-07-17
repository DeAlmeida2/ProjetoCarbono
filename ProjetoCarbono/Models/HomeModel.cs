using System.ComponentModel.DataAnnotations;

namespace ProjetoCarbono.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
        }

        public HomeModel(string transporte, string consumoVeiculo, string passageiros, string emissão)
        {
            Transporte = transporte;
            ConsumoVeiculo = consumoVeiculo;
            Passageiros = passageiros;
            Emissão = emissão;
        }

        public string Transporte { get; set; }
        public string ConsumoVeiculo { get; set; }
        public string Passageiros { get; set; }
        public string Emissão { get; set; }



    }
}
