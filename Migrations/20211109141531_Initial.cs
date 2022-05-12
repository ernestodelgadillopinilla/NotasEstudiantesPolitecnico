using Microsoft.EntityFrameworkCore.Migrations;

namespace NotasEstudiantesPolitecnico.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estudiante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nota1 = table.Column<decimal>(type: "float(2,2)", nullable: false),
                    Nota2 = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Nota3 = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    NotaFinal = table.Column<decimal>(type: "decimal(2,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datos");
        }
    }
}
