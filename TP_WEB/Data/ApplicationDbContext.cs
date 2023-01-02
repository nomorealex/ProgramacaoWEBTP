using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TP_WEB.Models;

namespace TP_WEB.Data
{
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser>
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}