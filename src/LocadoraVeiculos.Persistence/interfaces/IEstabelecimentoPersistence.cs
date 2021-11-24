using System.Threading.Tasks;
using LocadoraVeiculos.Domain;

namespace LocadoraVeiculos.Persistence.interfaces
{
    public interface IEstabelecimentoPersistence
    {
        Task<Estabelecimento[]> GetAllEstabelecimentosAsync(bool includeVeiculos);
        Task<Estabelecimento> GetEstabelecimentoByIdAsync(int EstabelecimentoId);
    }
}