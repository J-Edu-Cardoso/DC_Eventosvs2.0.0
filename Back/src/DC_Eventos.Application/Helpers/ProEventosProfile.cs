using System;
using AutoMapper;
using DC_Eventos.Application.Dtos;
using DC_Eventos.Domain;
using DC_Eventos.Domain.Identity;
using DC_Eventos.Persistence.Models;

namespace DC_Eventos.API.Helpers
{
    public class DC_EventosProfile : Profile
    {
        public DC_EventosProfile()
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
            CreateMap<Lote, LoteDto>().ReverseMap();
            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteAddDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteUpdateDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}