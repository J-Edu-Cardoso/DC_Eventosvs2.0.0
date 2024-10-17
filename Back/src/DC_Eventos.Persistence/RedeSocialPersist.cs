using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DC_Eventos.Domain;
using DC_Eventos.Persistence.Contextos;
using DC_Eventos.Persistence.Contratos;

namespace DC_Eventos.Persistence
{
    public class RedeSocialPersist : GeralPersist, IRedeSocialPersist
    {
        private readonly DC_EventosContext _context;

        public RedeSocialPersist(DC_EventosContext context) : base(context)
        {
            _context = context;
        }
        public async Task<RedeSocial> GetRedeSocialEventoByIdsAsync(int eventoId, int id) 
        {
            IQueryable<RedeSocial> query = _context.RedesSociais;

            query = query.AsNoTracking()
                         .Where(rs => rs.EventoId == eventoId &&
                                      rs.Id == id);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<RedeSocial> GetRedeSocialPalestranteByIdsAsync(int palestranteId, int id) 
        {
            IQueryable<RedeSocial> query = _context.RedesSociais;

            query = query.AsNoTracking()
                         .Where(rs => rs.PalestranteId == palestranteId &&
                                      rs.Id == id);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<RedeSocial[]> GetAllByEventoIdAsync(int eventoId) 
        {
            IQueryable<RedeSocial> query = _context.RedesSociais;

            query = query.AsNoTracking()
                         .Where(rs => rs.EventoId == eventoId);

            return await query.ToArrayAsync();
        }
        public async Task<RedeSocial[]> GetAllByPalestranteIdAsync(int palestranteId) 
        {
            IQueryable<RedeSocial> query = _context.RedesSociais;

            query = query.AsNoTracking()
                         .Where(rs => rs.PalestranteId == palestranteId);

            return await query.ToArrayAsync();
        }
    }
}