using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.Models
{
    public class EntradaSalida
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        
        public int CodigoEntradaSalida { get; set; }
        public bool Entrada { get; set; }
        public bool  Salida { get; set; }
        public int Cantidad { get; set; }
        public int BodegaId { get; set; }
        public int EmpleadoId { get; set; }
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        public Producto EntradaSalidaProducto { get; set; }
        public Empleado EntradaSalidaEmpleado { get; set; }
        public Bodega EntradaSalidaSede { get; set; }

        //public EntradaSalida()
        //{
            
        //}

        //public EntradaSalida CrearEntradaSalida(EntradaSalida entrada)
        //{
        //    return entrada;
        //}

        //public List<EntradaSalida> ObtenerPorFecha(DateTime entradaPorFecha)
        //{
        //    List<EntradaSalida> ListaFechas = new List<EntradaSalida>();
        //    return ListaFechas;
        //}
        
        //public List<EntradaSalida> ObtenerPorEntradaSaliaEmpleado(int codigoEmpleado)
        //{
        //    List<EntradaSalida> ListaEmpleado = new List<EntradaSalida>();
        //    return ListaEmpleado;
        //}

        //public EntradaSalida ActualizarEntradaSalida(EntradaSalida entradaSalida)
        //{
        //    return entradaSalida;
        //}

    }
        
}