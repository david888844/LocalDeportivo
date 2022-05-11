using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class Bodega
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        

        public int Id { get; set; }
        public string CodigoBodega { get; set; }
        //public int CantidadEmpleado { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<EntradaSalida> EntradaSalidas { get; set; }

        public Bodega()
        {
            Empleados = new HashSet<Empleado>();
            EntradaSalidas = new HashSet<EntradaSalida>();
        }

        public Bodega CrearBodega(Bodega Bodega)
        {
            return Bodega;
        }

        public string ActualizarBodega(Bodega bodega)
        {
            return "Bodega Actualizadas";
        }










    }


}