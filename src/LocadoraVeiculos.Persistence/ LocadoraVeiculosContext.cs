using LocadoraVeiculos.Domain;
using Microsoft.EntityFrameworkCore;

namespace LocadoraVeiculos.Persistence
{
    public class LocadoraVeiculosContext : DbContext
    {
        public LocadoraVeiculosContext(DbContextOptions<LocadoraVeiculosContext> options) : base(options) {}

        public DbSet<Estabelecimento> Estabelecimentos {get; set; }
        public DbSet<Veiculo> Veiculos {get; set; }
    }
}
