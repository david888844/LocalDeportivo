using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class Empleado : Persona
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        

        
        public int CodigoEmpleado { get; set;}
        public  int EdadEmpleado { get; set; }
        public Bodega EmpleadoBodega { get; set;}

        public Empleado()
        {
            
        }

        public Empleado CrearEmpleado(Empleado entradaEmpleado)
        {
            return entradaEmpleado;
        }

        public List<Empleado> ListarEmpleado()
        {
            List<Empleado> ListaEmpleado = new List<Empleado>();
            return ListaEmpleado;
        }
        
        public Empleado ActualizarEmpleado(Empleado entradaEmpleado)
        {
            return entradaEmpleado;
        }

        public string EliminarEmpleado(int CodigoEmpleado)
        {
            return "Empleado Eliminado";
        }

    }
}