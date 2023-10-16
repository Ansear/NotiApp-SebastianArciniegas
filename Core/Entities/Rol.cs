using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class Rol : BaseEntity
    {
        public string Nombre { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public DateOnly FechaModificacion { get; set; }
        public ICollection<RolVsMaestro> RolVsMaestros { get; set; }
        public ICollection<GenericosVsSubmodulos> GenericosVsSubmodulos {get;set;}
        
    }