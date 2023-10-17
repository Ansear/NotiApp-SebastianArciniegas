using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class Blockchain : BaseEntity
    {
        public int IdNotificacion { get; set; }
        public TipoNotificaciones TipoNotificaciones {get; set;}
        public int IdHiloRespuesta {get;set;}
        public HiloRespuestaNotificacion HiloRespuestaNotificaciones {get;set;}
        public int IdAuditoria {get;set;}
        public Auditoria Auditorias { get; set; }
        public string HasGenerado {get;set;}
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }