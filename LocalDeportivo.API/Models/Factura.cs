using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Factura
    {
        public int CodigoFactura { get; set; }
        public string CodigoCliente { get; set; }
        public string Nit { get; set; }
        public Date Fecha { get; set; }
        public ICollection<DetalleFactura> DetalleFacturas { get; set; }
        
    }
}