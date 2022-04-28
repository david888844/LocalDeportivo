using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Bodega
    {
         public string CodigoBodega { get; set; }
         //public int CantidadEmpleado { get; set; }
         public ICollection<Empleado> Empleados { get; set; }
         public ICollection<Producto> Productos { get; set; }
         public ICollection<EntradaSalida> EntradaSalidas { get; set; }
    }
}