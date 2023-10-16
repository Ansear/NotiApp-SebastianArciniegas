using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class MaestrosVsSubmodulos : BaseEntity
{
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public int IdMaestro {get;set;}
    public ModulosMaestros ModulosMaestros {get;set;}
    public int IdSubModulo {get;set;}
    public Submodulos Submodulos {get;set;}
    public ICollection<GenericosVsSubmodulos> GenericosVsSubmodulos {get;set;}
}