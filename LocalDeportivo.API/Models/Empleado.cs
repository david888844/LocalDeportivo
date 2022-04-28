using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public int EdadEmpleado { get; set; }
        public bodega EmpleadoBodega { get; set; }
        
    }
}