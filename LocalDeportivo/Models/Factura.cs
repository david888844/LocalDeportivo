using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
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
        public int ClienteId { get; set; }
        public ICollection<DetalleFactura> DetalleFacturas { get; set; }

        //public Factura(ICollection<DetalleFactura> detalleFactura)

        //{
        //    DetalleFacturas = detalleFactura;
        //}
        
        //public Factura CrearFactura(Factura entradaFactura)
        //{
        //    return entradaFactura;
        //}

        //public FacturaArchivo ListarFacturaPorCodigo(int codigoFactura)
        //{
        //    FacturaArchivo Codigo1 = new FacturaArchivo();
        //    return Codigo1;
        //}
    }
}