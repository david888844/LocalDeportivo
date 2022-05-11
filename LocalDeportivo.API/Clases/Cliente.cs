using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class Cliente : Persona
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoCliente { get; set; }
        public ICollection<Factura> Facturas { get; set; }

        public Cliente()

        {
            Facturas = new HashSet<Factura>();
        }
        
        public Cliente  CrearCliente(Cliente Cliente)

        {
            return Cliente;
        }
        
        public string ActualizarCliente()
        {
            return "ActualizarCliente";
        }

        public string ListarCliente()
        {
            return "Listado de Clientes ";
        }
        




       
    }
}