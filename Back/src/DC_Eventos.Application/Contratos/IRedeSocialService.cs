using System.Threading.Tasks;
using DC_Eventos.Application.Dtos;

namespace DC_Eventos.Application.Contratos
{
    public interface IRedeSocialService
    {
        Task<RedeSocialDto[]> SaveByEvento(int eventoId, RedeSocialDto[] models);
        Task<bool> DeleteByEvento(int eventoId, int redeSocialId);

        Task<RedeSocialDto[]> SaveByPalestrante(int palestranteId, RedeSocialDto[] models);
        Task<bool> DeleteByPalestrante(int palestranteId, int redeSocialId);

        Task<RedeSocialDto[]> GetAllByEventoIdAsync(int eventoId);
        Task<RedeSocialDto[]> GetAllByPalestranteIdAsync(int palestranteId);

        Task<RedeSocialDto> GetRedeSocialEventoByIdsAsync(int eventoId, int RedeSocialId);
        Task<RedeSocialDto> GetRedeSocialPalestranteByIdsAsync(int PalestranteId, int RedeSocialId);
    }
}