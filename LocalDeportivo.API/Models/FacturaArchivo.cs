using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class FacturaArchivo
    {
        public ICollection<Factura> Facturas { get; set; }
    }
}