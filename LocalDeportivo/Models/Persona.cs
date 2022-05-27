using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
{
    public abstract class Persona
    {
        
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //public Persona()
        //{
            
        //}

        //public Persona CrearPersona()
        //{
        //    Persona Persona1 = new Persona();
        //    return Persona1;
        //}

    }
}