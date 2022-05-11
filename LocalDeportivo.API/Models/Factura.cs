using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Factura
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        
        public int CodigoFactura { get; set; }
        public string CodigoCliente { get; set; }
        public string Nit { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<DetalleFactura> DetalleFacturas { get; set; }

        public Factura()

        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }
        
        public Factura CrearFactura(Factura entradaFactura)
        {
            return entradaFactura;
        }

        public Factura ListarFacturaPorCodigo(int codigoFactura)
        {
            Factura Codigo1 = new Factura();
            return Codigo1;
        }
    }
}