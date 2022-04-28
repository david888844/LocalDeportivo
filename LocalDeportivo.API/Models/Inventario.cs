using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Inventario
    {
        public string CodigoInventario { get; set; }
        public int Cantidad { get; set; }
        public Date Fecha { get; set; }
        public ICollection<EntradaSalida> EntradaSalidas { get; set; }
    }
}