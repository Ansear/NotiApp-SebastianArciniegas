using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ITipoRequerimiento TipoRequerimientos {get;}
        ITipoNotificaciones TipoNotificaciones { get;}
        ISubmodulos Submodulos {get;}
        IRolVsMaestro RolVsMaestro {get;}
        IRol Roles {get;}
        IRadicados Radicados {get;}
        IPermisosGenericos PermisosGenericos {get;}
        IModulosMaestros ModulosMaestros {get;}
        IModuloNotificaciones ModuloNotificaciones {get;}
        IMaestrosVsSubmodulos MaestrosVsSubmodulos {get;}
        IHiloRespuestaNotificacion HiloRespuestaNotificacion {get;}
        IGenericosVsSubmodulos GenericosVsSubmodulos {get;}
        IFormatos Formatos {get;}
        IEstadoNotificacion EstadoNotificacion {get;}
        IBlockchain Blockchain {get;}
        IAuditoria Auditoria {get;}
        Task<int> SaveAsync();
    }
}