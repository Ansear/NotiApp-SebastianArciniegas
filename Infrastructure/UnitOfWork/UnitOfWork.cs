using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly NotiAppContext _context;
    private IAuditoria _auditorias;
    private IBlockchain _blockchain;
    private IEstadoNotificacion _estadoNotificacion;
    private IFormatos _formato;
    private IGenericosVsSubmodulos _genericosVsSubmodulos;
    private IHiloRespuestaNotificacion _hiloRespuestaNotificacion;
    private IMaestrosVsSubmodulos _maestrosVsSubmodulos;
    private IModuloNotificaciones _moduloNotificaciones;
    private IModulosMaestros _modulosMaestros;
    private IPermisosGenericos _permisosGenericos;
    private IRadicados _radicados;
    private IRol _rol;
    private IRolVsMaestro _rolVsMaestro;
    private ISubmodulos _submodulos;
    private ITipoNotificaciones _tipoNotificaciones;
    private ITipoRequerimiento _tipoRequerimiento;
    public UnitOfWork(NotiAppContext context)
    {
        _context = context;
    }
    public ITipoRequerimiento TipoRequerimientos 
    {
        get
        {
            _tipoRequerimiento ??= new TipoRequerimientoRepository(_context);
            return _tipoRequerimiento;
        }
    }

    public ITipoNotificaciones TipoNotificaciones 
    {
        get
        {
            _tipoNotificaciones ??= new TipoNotificacionesRepository(_context);
            return _tipoNotificaciones;
        }
    }

    public ISubmodulos Submodulos
    {
        get
        {
            _submodulos ??= new SubmodulosRepository(_context);
            return _submodulos;
        }
    }

    public IRolVsMaestro RolVsMaestro
    {
        get
        {
            _rolVsMaestro ??= new RolVsMaestroRepository(_context);
            return _rolVsMaestro;
        }
    }

    public IRol Roles 
    {
        get
        {
            _rol ??= new RolRepository(_context);
            return _rol;
        }
    }

    public IRadicados Radicados
    {
        get
        {
            _radicados ??= new RadicadosRepository(_context);
            return _radicados;
        }
    }

    public IPermisosGenericos PermisosGenericos
    {
        get
        {
            _permisosGenericos ??= new PermisosGenericosRepository(_context);
            return _permisosGenericos;
        }
    }

    public IModulosMaestros ModulosMaestros
    {
        get
        {
            _modulosMaestros ??= new ModulosMaestrosRepository(_context);
            return _modulosMaestros;
        }
    }

    public IModuloNotificaciones ModuloNotificaciones
    {
        get
        {
            _moduloNotificaciones ??= new ModuloNotificacionesRepository(_context);
            return _moduloNotificaciones;
        }
    }

    public IMaestrosVsSubmodulos MaestrosVsSubmodulos
    {
        get
        {
            _maestrosVsSubmodulos ??= new MaestrosVsSubmodulosRepository(_context);
            return _maestrosVsSubmodulos;
        }
    }

    public IHiloRespuestaNotificacion HiloRespuestaNotificacion
    {
        get
        {
            _hiloRespuestaNotificacion ??= new HiloRespuestaNotificacionRepository(_context);
            return _hiloRespuestaNotificacion;
        }
    }

    public IGenericosVsSubmodulos GenericosVsSubmodulos
    {
        get
        {
            _genericosVsSubmodulos ??= new GenericosVsSubmodulosRepository(_context);
            return _genericosVsSubmodulos;
        }
    }

    public IFormatos Formatos
    {
        get
        {
            _formato ??= new FormatosRepository(_context);
            return _formato;
        }
    }

    public IEstadoNotificacion EstadoNotificacion
    {
        get
        {
            _estadoNotificacion ??= new EstadoNotificacionRepository(_context);
            return _estadoNotificacion;
        }
    }

    public IBlockchain Blockchain 
    {
        get
        {
            _blockchain ??= new BlockchainRepository(_context);
            return _blockchain;
        }
    }

    public IAuditoria Auditoria 
    {
        get
        {
            _auditorias ??= new AuditoriaRepository(_context);
            return _auditorias;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
