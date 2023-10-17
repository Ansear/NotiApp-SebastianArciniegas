using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;
public class GenericosVsSubmodulosDto
{
    public int Id { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public int IdGenericos { get; set; }
    public int IdRol { get; set; }
    public int IdSubModulos { get; set; }
}