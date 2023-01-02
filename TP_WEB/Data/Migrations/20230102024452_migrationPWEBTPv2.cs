using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_WEB.Data.Migrations
{
    public partial class migrationPWEBTPv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmpresarId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresasId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimeiroNome",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UltimoNome",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeiculoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservas_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Matricula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmpresasId",
                table: "AspNetUsers",
                column: "EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ApplicationUserId",
                table: "Reservas",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VeiculoId",
                table: "Reservas",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Empresas_EmpresasId",
                table: "AspNetUsers",
                column: "EmpresasId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Empresas_EmpresasId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmpresasId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmpresarId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmpresasId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrimeiroNome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UltimoNome",
                table: "AspNetUsers");
        }
    }
}
