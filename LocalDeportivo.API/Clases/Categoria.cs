using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class Categoria
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        
        public int CodigoCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public ICollection<Producto> Productos { get; set;}

        public Categoria()
        
        {
           Productos = new HashSet<Producto>();
        }
        
        
        public Categoria CrearCategoria (Categoria Categoria)

        {
            return Categoria;
        }
    
        public Categoria ActualizarCategoria (Categoria Categoria)

        {
           return Categoria;

        }
            
        public string ListarCategoria()


        { 
            return "Listado Categoria";
        }
        
        public List<Categoria> ObtenerCategoria()
        {
            List<Categoria> ListCategorias = new List<Categoria>(); 
            return ListCategorias;
        }

        

        public string EliminarCategoria()

        { 
            String MiCadena= "Eliminar Categoria sucess";
            return MiCadena;
        }



        

        
           
        
        


    }
}