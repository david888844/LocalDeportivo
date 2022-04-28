using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class ProductoArchivo
    {
        public ICollection<Producto> Productos { get; set; }
    }
}