using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lavanderias",
                columns: table => new
                {
                    N_Servicios = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    N_Cuarto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lavanderias", x => x.N_Servicios);
                });

            migrationBuilder.CreateTable(
                name: "Cuartos",
                columns: table => new
                {
                    N_Cuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    N_servicios = table.Column<int>(type: "int", nullable: false),
                    Uso_Parqueadero = table.Column<bool>(type: "bit", nullable: false),
                    LavanderiaN_Servicios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuartos", x => x.N_Cuarto);
                    table.ForeignKey(
                        name: "FK_Cuartos_lavanderias_LavanderiaN_Servicios",
                        column: x => x.LavanderiaN_Servicios,
                        principalTable: "lavanderias",
                        principalColumn: "N_Servicios");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuartos_LavanderiaN_Servicios",
                table: "Cuartos",
                column: "LavanderiaN_Servicios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuartos");

            migrationBuilder.DropTable(
                name: "lavanderias");
        }
    }
}
