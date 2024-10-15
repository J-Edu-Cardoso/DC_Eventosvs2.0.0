using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DC_Eventos.Application.Dtos;

namespace DC_Eventos.Application.Contratos
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}