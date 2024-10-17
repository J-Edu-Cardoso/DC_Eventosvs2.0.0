using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DC_Eventos.Domain.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}