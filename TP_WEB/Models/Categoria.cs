using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TP_WEB.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }


    }
}
