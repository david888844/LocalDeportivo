using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalDeportivo.API.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LocalDeportivo.API.LocalDeportivoDbContextFolder
{
    public class LocalDeportivoDbContext : DbContext
    {

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
        public LocalDeportivoDbContext(DbContextOptions<LocalDeportivoDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Database schema
            builder.HasDefaultSchema("dbo");

            base.OnModelCreating(builder);

            //Model Contraints
            ModelConfig(builder);
            builder.HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            //throw new NotImplementedException();
        }
    }
}