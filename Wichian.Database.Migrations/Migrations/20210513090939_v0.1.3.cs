using Microsoft.EntityFrameworkCore.Migrations;

namespace Wichian.Database.Migrations.Migrations
{
    public partial class v013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bom_materiel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false, comment: "Id主键")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bom_materiel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bom_materiel_MaterielBase_Id",
                        column: x => x.Id,
                        principalTable: "MaterielBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "物料信息表");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bom_materiel");
        }
    }
}
