using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class DetalleFactura
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        

        
        public int CodigoDetalleFactura { get; set; }
        public string Descripcion { get; set; }
        public Producto Producto { get; set; }
        public  int Cantidad { get; set; }
        public float Precio { get; set; }
        public int Factura { get; set; }
        public Factura FacturaId { get; set; }

        public DetalleFactura()
        {
            
        }
        public DetalleFactura CrearDetalleFactura(DetalleFactura entradaDetalleFactura)
        { 
            return entradaDetalleFactura;
        }

        public DetalleFactura ListarDetalleFactura(int CodigoDetalleFactura)
        {
            DetalleFactura DetalleFactura1 = new DetalleFactura();
            return DetalleFactura1;
        }

        public int DescontarStock()
        {
            int Stock = new int();
            return Stock;
        }

        public int  CalcularPrecio()
        {
            int Precio = new int();
            return Precio;
        }



        }
    }

   

