using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class Sede
    {
        public string CodigoSede { get; set; }
        public string NombreSede { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefonico { get; set; }
        public Bodega SedeBodega { get; set; }

    }
}