using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Cliente
    {
        public string CodigoCliente { get; set; }
        public ICollection<Factura> Facturas { get; set; }
        
    }
}