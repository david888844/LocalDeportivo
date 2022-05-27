using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
{
    public class Sede
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
 
        public int CodigoSede { get; set; }
        public string NombreSede { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefonico { get; set; }
        public int BodegaId { get; set; }
        public Bodega SedeBodega { get; set; }    

        //public Sede(Bodega sedeBodega)
        //{
            
        //}
        
        //public Sede CrearSede(Sede entradaSede)
        //{
        //    return entradaSede;
        //}
        
        //public List<Sede>  ListarSede(Sede codigoSede)
        //{
        //    List<Sede> ListaSedes = new List<Sede>();
        //    return ListaSedes;
        //}

        //public Bodega ActualizarSede()
        //{
        //     Bodega Sede1= new Bodega();
        //    return  Sede1;
        //}

        //public string EliminarSede()
        //{
        //    return "Eliminar Sede";
        //}
   
    }
} 
        

    


            
       