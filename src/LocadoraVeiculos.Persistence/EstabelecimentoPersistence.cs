using System.Linq;
using System.Threading.Tasks;
using LocadoraVeiculos.Domain;
using LocadoraVeiculos.Persistence.interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocadoraVeiculos.Persistence
{
    public class EstabelecimentoPersistence : IEstabelecimentoPersistence
    {
        private readonly LocadoraVeiculosContext _context;
        public EstabelecimentoPersistence(LocadoraVeiculosContext context)
        {
            this._context = context;

        }

        public async Task<Estabelecimento[]> GetAllEstabelecimentosAsync(bool includeVeiculos)
        {
            IQueryable<Estabelecimento> query = _context.Estabelecimentos;

            if (includeVeiculos) {
                query = query.Include(e => e.Veiculos);
            }

            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Estabelecimento> GetEstabelecimentoByIdAsync(int EstabelecimentoId)
        {
            IQueryable<Estabelecimento> query = _context.Estabelecimentos;

            query = query.OrderBy(e => e.Id).Where(e => e.Id == EstabelecimentoId);

            return await query.FirstOrDefaultAsync();
        }
    }
}