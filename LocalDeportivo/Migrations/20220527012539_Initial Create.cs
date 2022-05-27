using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LocalDeportivo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoBodega = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CodigoCategoria = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCategoria = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CodigoCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodigoCliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Correo = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodigoCliente);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    CodigoInventario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.CodigoInventario);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    CodigoProveedor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreProveedor = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.CodigoProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    CodigoEmpleado = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EdadEmpleado = table.Column<int>(type: "integer", nullable: false),
                    BodegaId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Correo = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.CodigoEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    CodigoSede = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreSede = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    NumeroTelefonico = table.Column<string>(type: "text", nullable: true),
                    BodegaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.CodigoSede);
                    table.ForeignKey(
                        name: "FK_Sedes_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    CodigoFactura = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoCliente = table.Column<string>(type: "text", nullable: true),
                    Nit = table.Column<string>(type: "text", nullable: true),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.CodigoFactura);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "CodigoCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    CodigoProducto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Precio = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    Talla = table.Column<string>(type: "text", nullable: true),
                    NombreProducto = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    ProveedorCodigoProveedor = table.Column<int>(type: "integer", nullable: true),
                    TipoProductoCodigoCategoria = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.CodigoProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_TipoProductoCodigoCategoria",
                        column: x => x.TipoProductoCodigoCategoria,
                        principalTable: "Categorias",
                        principalColumn: "CodigoCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_ProveedorCodigoProveedor",
                        column: x => x.ProveedorCodigoProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "CodigoProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFacturas",
                columns: table => new
                {
                    CodigoDetalleFactura = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    ProductoCodigoProducto = table.Column<int>(type: "integer", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    FacturaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturas", x => x.CodigoDetalleFactura);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "CodigoFactura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Productos_ProductoCodigoProducto",
                        column: x => x.ProductoCodigoProducto,
                        principalTable: "Productos",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntradaSalidas",
                columns: table => new
                {
                    CodigoEntradaSalida = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Entrada = table.Column<bool>(type: "boolean", nullable: false),
                    Salida = table.Column<bool>(type: "boolean", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    BodegaId = table.Column<int>(type: "integer", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InventarioCodigoInventario = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaSalidas", x => x.CodigoEntradaSalida);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "CodigoEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Inventarios_InventarioCodigoInventario",
                        column: x => x.InventarioCodigoInventario,
                        principalTable: "Inventarios",
                        principalColumn: "CodigoInventario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaSalidas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_FacturaId",
                table: "DetalleFacturas",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_ProductoCodigoProducto",
                table: "DetalleFacturas",
                column: "ProductoCodigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_BodegaId",
                table: "Empleados",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_BodegaId",
                table: "EntradaSalidas",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_EmpleadoId",
                table: "EntradaSalidas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_InventarioCodigoInventario",
                table: "EntradaSalidas",
                column: "InventarioCodigoInventario");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaSalidas_ProductoId",
                table: "EntradaSalidas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorCodigoProveedor",
                table: "Productos",
                column: "ProveedorCodigoProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoProductoCodigoCategoria",
                table: "Productos",
                column: "TipoProductoCodigoCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_BodegaId",
                table: "Sedes",
                column: "BodegaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleFacturas");

            migrationBuilder.DropTable(
                name: "EntradaSalidas");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
