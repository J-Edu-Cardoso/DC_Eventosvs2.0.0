using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DC_Eventos.Domain.Identity;
using DC_Eventos.Persistence.Contextos;
using DC_Eventos.Persistence.Contratos;

namespace DC_Eventos.Persistence
{
    public class UserPersist : GeralPersist, IUserPersist
    {
        private readonly DC_EventosContext _context;

        public UserPersist(DC_EventosContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users
                                 .SingleOrDefaultAsync(user => user.UserName == userName.ToLower());
        }
    }
}