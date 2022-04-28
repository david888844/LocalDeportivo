using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Categoria
    {
        public int CodigoCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public ICollection<Producto> Productos { get; set;}
    }
}