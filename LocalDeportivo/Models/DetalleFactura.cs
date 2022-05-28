using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
{
    public class DetalleFactura
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoDetalleFactura { get; set; }
        public string Descripcion { get; set; }
        public  int Cantidad { get; set; }
        public float Precio { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }

        //public DetalleFactura(Producto producto)
        //{
        //    Producto = producto;
        //}

        //public DetalleFactura CrearDetalleFactura(DetalleFactura entradaDetalleFactura)
        //{ 
        //    return entradaDetalleFactura;
        //}

        //public FacturaArchivo ListarDetalleFactura(int CodigoDetalleFactura)
        //{
        //    FacturaArchivo DetalleFactura  = new FacturaArchivo();
        //    return DetalleFactura;
        //}

        //public int DescontarStock()
        //{
        //    int Stock = new int();
        //    return Stock;
        //}

        //public int  CalcularPrecio()
        //{
        //    int Precio = new int();
        //    return Precio;
        //}



        }
    }

   

