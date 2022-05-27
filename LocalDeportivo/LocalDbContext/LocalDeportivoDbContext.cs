using LocalDeportivo.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalDeportivo.LocalDbContext
{
    public class LocalDeportivoDbContext : DbContext
    {
        public LocalDeportivoDbContext(DbContextOptions<LocalDeportivoDbContext> options):base(options) 
        {
        }

        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<EntradaSalida> EntradaSalidas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Sede> Sedes { get; set; }
    }
}
