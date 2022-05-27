using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
{
    public class Inventario
    {
        public Inventario()
        {
            EntradaSalidas = new HashSet<EntradaSalida>();
        }
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             
        
        public int  CodigoInventario { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<EntradaSalida> EntradaSalidas { get; set; }

        /* public Inventario(ICollection<EntradaSalida> entradaSalida)
        {
            EntradaSalidas = entradaSalida;
        } */

        //public  void MostrarInventario()
        //{
            
        //}

    }
}