using System.Threading.Tasks;
using DC_Eventos.Domain;

namespace DC_Eventos.Persistence.Contratos
{
    public interface IRedeSocialPersist : IGeralPersist
    {
        Task<RedeSocial> GetRedeSocialEventoByIdsAsync(int eventoId, int id);
        Task<RedeSocial> GetRedeSocialPalestranteByIdsAsync(int palestranteId, int id);
        Task<RedeSocial[]> GetAllByEventoIdAsync(int eventoId);
        Task<RedeSocial[]> GetAllByPalestranteIdAsync(int palestranteId);
    }
}