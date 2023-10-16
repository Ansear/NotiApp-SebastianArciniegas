using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class GenericosVsSubmodulos : BaseEntity
{
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public int IdGenericos {get;set;}
    public PermisosGenericos PermisosGenericos {get;set;}
    public int IdRol {get;set;}
    public Rol Roles {get;set;}
    public int IdSubModulos {get;set;}
    public MaestrosVsSubmodulos MaestrosVsSubmodulos {get;set;}
}