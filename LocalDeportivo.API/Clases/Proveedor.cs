using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Clases
{
    public class Proveedor
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nit { get; set; }
        
        public ICollection<Producto> Productos { get; set; }

        
        public Proveedor()

        {
            Productos = new HashSet<Producto>();
        }

        public Proveedor CrearProveedor(Proveedor entradaProveedor)
        {
            return entradaProveedor;
        }    

        public Proveedor ActualizarProveedor(Proveedor entradaProveedor)
        {
            return entradaProveedor;
        }

        public List<Proveedor> ObtenerProveedorPorCategoria(int codigoCategoria)
        {
            List<Proveedor> ListaDeProveedor = new List<Proveedor>();
            return ListaDeProveedor;
        }
        
        public List<Proveedor> ListarProveedor(Proveedor codigoProveedor)
        {
            List<Proveedor> ListaProveedor = new List<Proveedor>();
            return  ListaProveedor;
        }

        public string EliminarProveedor()
        {
            return "Eliminar Proveedor";
        }
    }
}