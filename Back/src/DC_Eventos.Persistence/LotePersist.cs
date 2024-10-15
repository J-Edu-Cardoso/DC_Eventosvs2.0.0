using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DC_Eventos.Domain;
using DC_Eventos.Persistence.Contextos;
using DC_Eventos.Persistence.Contratos;

namespace DC_Eventos.Persistence
{
    public class LotePersist : ILotePersist
    {
        private readonly DC_EventosContext _context;
        public LotePersist(DC_EventosContext context)
        {
            _context = context;
        }

        public async Task<Lote> GetLoteByIdsAsync(int eventoId, int id)
        {
            IQueryable<Lote> query = _context.Lotes;

            query = query.AsNoTracking()
                         .Where(lote => lote.EventoId == eventoId
                                     && lote.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Lote[]> GetLotesByEventoIdAsync(int eventoId)
        {
            IQueryable<Lote> query = _context.Lotes;

            query = query.AsNoTracking()
                         .Where(lote => lote.EventoId == eventoId);

            return await query.ToArrayAsync();
        }
    }
}