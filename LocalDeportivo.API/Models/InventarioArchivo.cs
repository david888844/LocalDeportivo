using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class InventarioArchivo
    {
        public ICollection<Inventario> Inventario { get; set; }
        
    }
}