using System.Threading.Tasks;
using LocadoraVeiculos.Domain;

namespace LocadoraVeiculos.Persistence.interfaces
{
    public interface IEstabelecimentoPersistence
    {
        Task<Estabelecimento[]> GetAllEstabelecimentosAsync();
        Task<Estabelecimento> GetEstabelecimentoByIdAsync(int EstabelecimentoId);
    }
}