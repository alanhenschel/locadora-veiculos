using System.Threading.Tasks;
using LocadoraVeiculos.Domain;

namespace LocadoraVeiculos.Persistence.interfaces
{
    public interface IVeiculoPersistence
    {
        Task<Veiculo[]> GetAllVeiculosAsync(bool includeEstabelecimento);
        Task<Veiculo> GetVeiculoByIdAsync(int VeiculoId, bool includeEstabelecimento);
    }
}