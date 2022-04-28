using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class EntadraSalida
    {
        public int CodigoEntradaSalida { get; set; }
        public bool Entrada { get; set; }
        public bool  Salida { get; set; }
        public int Cantidad { get; set; }
        public Date Fecha { get; set; }
        public Producto EntadraSalidaProducto { get; set; }
        public Empleado EntadraSalidaEmpleado { get; set; }
        public Sede EntadraSalidaSede { get; set; }

    }
}