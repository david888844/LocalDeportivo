using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class EmpleadoArchivo
    {
        public ICollection<Empleado> Empleados { get; set; }

        public EmpleadoArchivo()
        {
            
        }

        public EmpleadoArchivo CrearEmpleadoArchivo()
        {
            EmpleadoArchivo Empleado = new EmpleadoArchivo();
            return Empleado;
        }

        public EmpleadoArchivo GuardarEmpleadoArchivo()
        {
            EmpleadoArchivo Empleado = new EmpleadoArchivo();
            return Empleado;
        }

        public EmpleadoArchivo ModificarEmpleadoArchivo()
        {
            EmpleadoArchivo Empleado = new EmpleadoArchivo();
            return Empleado;
        }

        public EmpleadoArchivo EliminarEmpleadoArchivo()
        {
            EmpleadoArchivo Empleado = new EmpleadoArchivo();
            return Empleado;
        }
    }   


    
}