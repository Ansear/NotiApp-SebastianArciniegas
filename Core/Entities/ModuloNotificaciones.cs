using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class ModuloNotificaciones : BaseEntity
{
    public string AsuntoNotificacion { get; set; }
    public int IdTipoNotificacion { get; set; }
    public TipoNotificaciones TipoNotificaciones { get; set; }
    public int IdRadicado { get; set; }
    public Radicados Radicados { get; set; }
    public int IdEstadoNotificacion { get; set; }
    public EstadoNotificacion EstadoNotificaciones { get; set; }
    public int IdHiloRespuesta { get; set; }
    public HiloRespuestaNotificacion HiloRespuestaNotificaciones { get; set; }
    public int IdFormato { get; set; }
    public Formatos Formatos { get; set; }
    public int IdRequereimiento { get; set; }
    public TipoRequerimiento TipoRequerimientos { get; set; }
    public string TextoNotificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }

}
