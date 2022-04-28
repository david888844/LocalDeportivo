using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Proveedor
    {
        public string CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nit { get; set; }
        public ICollection<Producto> Productos { get; set; }
        
    }
}