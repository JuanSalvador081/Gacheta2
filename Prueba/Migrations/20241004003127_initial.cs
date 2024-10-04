using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    N_Documento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Parqueadero = table.Column<bool>(type: "bit", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motivo_hospedaje = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.N_Documento);
                });

            migrationBuilder.CreateTable(
                name: "Lavanderias",
                columns: table => new
                {
                    Id_Lavanderia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_Cuarto = table.Column<int>(type: "int", nullable: false),
                    N_Servicios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lavanderias", x => x.Id_Lavanderia);
                });

            migrationBuilder.CreateTable(
                name: "Cuartos",
                columns: table => new
                {
                    Numero_Cuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_Documento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuartos", x => x.Numero_Cuarto);
                    table.ForeignKey(
                        name: "FK_Cuartos_Clientes_N_Documento",
                        column: x => x.N_Documento,
                        principalTable: "Clientes",
                        principalColumn: "N_Documento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historia_Clientes",
                columns: table => new
                {
                    ID_Historia = table.Column<int>(type: "int", nullable: false),
                    N_Documento = table.Column<int>(type: "int", nullable: false),
                    N_Visitas = table.Column<int>(type: "int", nullable: false),
                    F_entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    F_salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N_T_Lavanderia = table.Column<int>(type: "int", nullable: false),
                    N_Historia_cuarto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historia_Clientes", x => new { x.ID_Historia, x.N_Documento });
                    table.ForeignKey(
                        name: "FK_Historia_Clientes_Clientes_N_Documento",
                        column: x => x.N_Documento,
                        principalTable: "Clientes",
                        principalColumn: "N_Documento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuartos_N_Documento",
                table: "Cuartos",
                column: "N_Documento");

            migrationBuilder.CreateIndex(
                name: "IX_Historia_Clientes_N_Documento",
                table: "Historia_Clientes",
                column: "N_Documento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuartos");

            migrationBuilder.DropTable(
                name: "Historia_Clientes");

            migrationBuilder.DropTable(
                name: "Lavanderias");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
