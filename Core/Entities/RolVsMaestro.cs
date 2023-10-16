using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class RolVsMaestro : BaseEntity
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdRol { get; set; }
        public Rol Roles { get; set; }
        public int IdMaestro { get; set; }
        public ModulosMaestros ModulosMaestros {get;set;}
    }