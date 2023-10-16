using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Submodulos : BaseEntity
{
    public string NombreSubModulo { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public ICollection<MaestrosVsSubmodulos> MaestrosVsSubmodulos {get;set;}
}