using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LocalDeportivo.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Bodegas",
                schema: "dbo",
                columns: table => new
                {
                    IdBodega = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoBodega = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.IdBodega);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                schema: "dbo",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCategoria = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "dbo",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoCliente = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Correo = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                schema: "dbo",
                columns: table => new
                {
                    IdInventario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoInventario = table.Column<string>(type: "text", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.IdInventario);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                schema: "dbo",
                columns: table => new
                {
                    IdProveedor = table.Column<string>(type: "text", nullable: false),
                    NombreProveedor = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                schema: "dbo",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoEmpleado = table.Column<int>(type: "integer", nullable: false),
                    EdadEmpleado = table.Column<int>(type: "integer", nullable: false),
                    EmpleadoBodegaId = table.Column<int>(type: "integer", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Correo = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_Empleados_Bodegas_EmpleadoBodegaId",
                        column: x => x.EmpleadoBodegaId,
                        principalSchema: "dbo",
                        principalTable: "Bodegas",
                        principalColumn: "IdBodega",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                schema: "dbo",
                columns: table => new
                {
                    IdSede = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoSede = table.Column<string>(type: "text", nullable: true),
                    NombreSede = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    NumeroTelefonico = table.Column<string>(type: "text", nullable: true),
                    SedeBodegaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.IdSede);
                    table.ForeignKey(
                        name: "FK_Sedes_Bodegas_SedeBodegaId",
                        column: x => x.SedeBodegaId,
                        principalSchema: "dbo",
                        principalTable: "Bodegas",
                        principalColumn: "IdBodega",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                schema: "dbo",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoFactura = table.Column<int>(type: "integer", nullable: false),
                    CodigoCliente = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Clienteid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_Clienteid",
                        column: x => x.Clienteid,
                        principalSchema: "dbo",
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "dbo",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoProducto = table.Column<string>(type: "text", nullable: true),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Precio = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    Talla = table.Column<string>(type: "text", nullable: true),
                    NombreProducto = table.Column<string>(type: "text", nullable: true),
                    ProveedorCodigoProveedor = table.Column<string>(type: "text", nullable: true),
                    TipoProductoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_TipoProductoId",
                        column: x => x.TipoProductoId,
                        principalSchema: "dbo",
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_ProveedorCodigoProveedor",
                        column: x => x.ProveedorCodigoProveedor,
                        principalSchema: "dbo",
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFacturas",
                schema: "dbo",
                columns: table => new
                {
                    IdDetalle = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoDetalleFactura = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    ProductoId = table.Column<int>(type: "integer", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Factura = table.Column<int>(type: "integer", nullable: false),
                    FacturaIdId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturas", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Facturas_FacturaIdId",
                        column: x => x.FacturaIdId,
                        principalSchema: "dbo",
                        principalTable: "Facturas",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalSchema: "dbo",
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntradaSalidas",
                schema: "dbo",
                columns: table => new
                {
                    IdEntradaSalid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoEntradaSalida = table.Column<int>(type: "integer", nullable: false),
                    Entrada = table.Column<bool>(type: "boolean", nullable: false),
                    Salida = table.Column<bool>(type: "boolean", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EntradaSalidaProductoId = table.Column<int>(type: "integer", nullable: true),
                    EntradaSalidaEmpleadoId = table.Column<int>(type: "integer", nullable: true),
                    EntradaSalidaSedeId = table.Column<int>(type: "integer", nullable: true),
                    BodegaId = table.Column<int>(type: "integer", nullable: true),
                    InventarioId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaSalidas", x => x.IdEntradaSalid);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalSchema: "dbo",
                        principalTable: "Bodegas",
                        principalColumn: "IdBodega",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Empleados_EntradaSalidaEmpleadoId",
                        column: x => x.EntradaSalidaEmpleadoId,
                        principalSchema: "dbo",
                        principalTable: "Empleados",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Inventarios_InventarioId",
                        column: x => x.InventarioId,
                        principalSchema: "dbo",
                        principalTable: "Inventarios",
                        principalColumn: "IdInventario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Productos_EntradaSalidaProductoId",
                        column: x => x.EntradaSalidaProductoId,
                        principalSchema: "dbo",
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Sedes_EntradaSalidaSedeId",
                        column: x => x.EntradaSalidaSedeId,
                        principalSchema: "dbo",
                        principalTable: "Sedes",
                        principalColumn: "IdSede",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_FacturaIdId",
                schema: "dbo",
                table: "DetalleFacturas",
                column: "FacturaIdId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_ProductoId",
                schema: "dbo",
                table: "DetalleFacturas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_EmpleadoBodegaId",
                schema: "dbo",
                table: "Empleados",
                column: "EmpleadoBodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_BodegaId",
                schema: "dbo",
                table: "EntradaSalidas",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_EntradaSalidaEmpleadoId",
                schema: "dbo",
                table: "EntradaSalidas",
                column: "EntradaSalidaEmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_EntradaSalidaProductoId",
                schema: "dbo",
                table: "EntradaSalidas",
                column: "EntradaSalidaProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_EntradaSalidaSedeId",
                schema: "dbo",
                table: "EntradaSalidas",
                column: "EntradaSalidaSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_InventarioId",
                schema: "dbo",
                table: "EntradaSalidas",
                column: "InventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Clienteid",
                schema: "dbo",
                table: "Facturas",
                column: "Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorCodigoProveedor",
                schema: "dbo",
                table: "Productos",
                column: "ProveedorCodigoProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoProductoId",
                schema: "dbo",
                table: "Productos",
                column: "TipoProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_SedeBodegaId",
                schema: "dbo",
                table: "Sedes",
                column: "SedeBodegaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleFacturas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EntradaSalidas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Facturas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Empleados",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Inventarios",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Productos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sedes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categorias",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Proveedores",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Bodegas",
                schema: "dbo");
        }
    }
}
