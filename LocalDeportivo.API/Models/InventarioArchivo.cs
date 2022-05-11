using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDeportivo.API.Models
{
    public class InventarioArchivo
    {
        public ICollection<Inventario> Inventario { get; set; }

        public InventarioArchivo()    
        {
            
        }

        public InventarioArchivo GuardarInventarioArchivo()
        {
            InventarioArchivo  Inventario = new InventarioArchivo();
            return Inventario;
        }

        public InventarioArchivo ModificarInventario()
        {
            InventarioArchivo Inventario = new InventarioArchivo();
            return Inventario;
        }
        
        public InventarioArchivo EliminarInventario()
        {
            InventarioArchivo Inventario = new InventarioArchivo();
            return Inventario;
        }
    }
}