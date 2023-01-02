using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace TP_WEB.Models
{
    public class Veiculo
    {

        [Key]
        [Required]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Display(Name = "Número de lugares")]
        public int Nlugares { get; set; }

        [Display(Name = "Cilindrada")]
        public int Cilindrada { get; set; }

        [Display(Name = "Potência")]
        public int Potencia { get; set; }

        [Display(Name = "Caixa de Velocidade")]
        public string CaixaVelocidades { get; set; }

        [Display(Name = "Ar de condicionado")]
        public bool ArCondicionado { get; set; }

        [Display(Name = "Combustível")]
        public string Combustivel { get; set; }

        [Display(Name = "Ano de construção")]
        public DateTime AnoDeConstrucao { get; set; }

        [Display(Name = "Preço")]
        public decimal? Preco { get; set; }

        public int? CategoriaId { get; set; }
        public Categoria categoria { get; set; }


        public int? EmpresaId { get; set; }
        public Empresa empresa { get; set; }
    }
}
