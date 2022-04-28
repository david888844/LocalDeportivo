using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public string  Talla { get; set; }
        public string NombreProducto { get; set; }
        public Proveedor Proveedor { get; set; }
        public Categoria TipoProducto { get; set; }
    }
}