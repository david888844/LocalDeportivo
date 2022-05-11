using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class FacturaArchivo
    {
        public ICollection<Factura> Facturas { get; set; }

        public FacturaArchivo()
        {
            
        }

        public FacturaArchivo GuardarFacturArchivo()
        {
            FacturaArchivo Factura = new FacturaArchivo();
            return Factura;
        }

        public FacturaArchivo ModificarFacturaArchivo()
        {
            FacturaArchivo Factura = new FacturaArchivo();
            return Factura;
        }

        public FacturaArchivo EliminarFacturaArchivo()
        {
            FacturaArchivo Factura = new FacturaArchivo();
            return Factura;
        }

    }
}