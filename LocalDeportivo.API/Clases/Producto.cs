using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Producto
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             
        public int CodigoProducto { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public string  Talla { get; set; }
        public string NombreProducto { get; set; }
        public Proveedor Proveedor { get; set; }
        public Categoria TipoProducto { get; set; }

        public Producto()
        {
            
        }

        public Producto CrearProducto(Producto Producto)
        {
            return Producto;
        }

        public string ActualizarProducto(Producto Producto)
        {
            return "Actualizar Producto";
        }

        public Producto ListaProducto(int CodigoProducto)
        {   
            Producto c1 = new Producto();
            return c1;
        }

        public List<Producto> ObtenerProductoPorProveedor(int codigoProveedor)
        {
            List<Producto>  ListaDeProductos = new List<Producto>();
            return ListaDeProductos;
        }

        public List<Producto> ObtenerProductoPorCategoria(int codigoCategoria)
        {   
            List<Producto> ListaDeProducto = new List<Producto>();
            return ListaDeProducto;
        }

        public int CantidadDeProducto()
        {
            int Cantidad = new int();
            return Cantidad;
        }

        public string EliminarProducto()
        {
            return "Productos elimimados";
        } 
    
    } 





    }
    

    
    