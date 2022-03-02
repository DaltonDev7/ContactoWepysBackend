using Microsoft.EntityFrameworkCore.Migrations;

namespace contactosPruebas.Migrations
{
    public partial class craeteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_Email",
                table: "Contacto",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacto");
        }
    }
}
