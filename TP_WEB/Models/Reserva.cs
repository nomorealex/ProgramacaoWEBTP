namespace TP_WEB.Models
{
    public class Reserva
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public string VeiculoId { get; set; }

        public Veiculo veiculo { get; set; }

    }
}
