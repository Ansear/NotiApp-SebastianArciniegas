using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles;
    public class MappingProfile : Profile
    {
        //AspNetCoreRateLimit En Api.csproj
        public MappingProfile()
        {
            CreateMap<Auditoria, AuditoriaDto>().ReverseMap();
            CreateMap<Blockchain, BlockchainDto>().ReverseMap();
            CreateMap<EstadoNotificacion, EstadoNotificacionDto>().ReverseMap();
            CreateMap<Formatos, FormatosDto>().ReverseMap();
            CreateMap<GenericosVsSubmodulos, GenericosVsSubmodulosDto>().ReverseMap();
            CreateMap<HiloRespuestaNotificacion, HiloRespuestaNotificacionDto>().ReverseMap();
            CreateMap<MaestrosVsSubmodulos, MaestroVsSubmodulosDto>().ReverseMap();
            CreateMap<ModuloNotificaciones, ModuloNotificacionesDto>().ReverseMap();
            CreateMap<ModulosMaestros, ModulosMaestrosDto>().ReverseMap();
            CreateMap<PermisosGenericos, PermisosGenericosDto>().ReverseMap();
            CreateMap<Radicados, RadicadosDto>().ReverseMap();
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<RolVsMaestro, RolVsMaestrosDto>().ReverseMap();
            CreateMap<Submodulos, SubmodulosDto>().ReverseMap();
            CreateMap<TipoNotificaciones, TipoNotificacionesDto>().ReverseMap();
            CreateMap<TipoRequerimiento, TipoRequerimientoDto>().ReverseMap();
        }
    }