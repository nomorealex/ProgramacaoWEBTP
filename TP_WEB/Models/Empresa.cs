using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TP_WEB.Models
{
    public class Empresa
    {

        public int Id { get; set; }

        [Display(Name = "Empresa")]
        public string Nome { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }

        public ICollection<ApplicationUser> Trabalhadores { get; set; }
    }
}
