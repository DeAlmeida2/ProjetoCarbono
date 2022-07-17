namespace ProjetoCarbono.Models
{
    public class CO2Model
    {
        public int Id { get; set; }
        public string? Transporte { get; set; }
        public double ConsumoVeiculo { get; set; }
        public int Passageiros { get; set; }
        public double Emissão { get; set; }
        public double Km { get; set; }
        public double Calculo { get; set; }
        public double Compensacao { get; set; }
        public double Credito { get; set; }


    }
}