using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class TipoNotificacionesRepository : GenericRepository<TipoNotificaciones>, ITipoNotificaciones
{
    private readonly NotiAppContext _context;

    public TipoNotificacionesRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }
}