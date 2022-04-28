using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class DetalleFactura
    {
        public int CodigoDetalleFactura { get; set; }
        public string Descripcion { get; set; }
        public producto Producto { get; set; }
        public  int Cantidad { get; set; }
        public float Precio { get; set; }
        public int Factura { get; set; }
        public Factura FacturaId { get; set; }
    }
}