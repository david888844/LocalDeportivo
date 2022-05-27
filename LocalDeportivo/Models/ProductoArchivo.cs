using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
{
    public class ProductoArchivo
    {
        public ICollection<Producto> Productos { get; set; }

        public ProductoArchivo()
        {
            
        }

        public ProductoArchivo CrearProductoArchivo()
        {
            ProductoArchivo Producto = new ProductoArchivo();
            return Producto;
        }

        public ProductoArchivo GuardarProductoArchivo()
        {
            ProductoArchivo Producto = new ProductoArchivo();
            return Producto;
        }

        public ProductoArchivo ModificarProductoArchivo()
        {
            ProductoArchivo Producto = new ProductoArchivo();
            return Producto; 
        }

        public ProductoArchivo EliminarProductoArchivo()
        {
            ProductoArchivo Producto = new ProductoArchivo();
            return Producto;
        }
        

    }
}