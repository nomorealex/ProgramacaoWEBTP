using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TP_WEB.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Primeiro Nome")]
        public string PrimeiroNome { get; set; }

        [Display(Name = "Último Nome")]
        public string UltimoNome { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public int? EmpresarId { get; set; }
        public Empresa? Empresas { get; set; }

        public ICollection<Reserva> reservas { get; set; }
    }
}
