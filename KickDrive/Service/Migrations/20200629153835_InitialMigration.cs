using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: false),
                    NombreProp = table.Column<string>(nullable: true),
                    Automovil = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    FechaExpedicion = table.Column<string>(nullable: true),
                    Vigencia = table.Column<string>(nullable: true),
                    NumeroMotor = table.Column<string>(nullable: true),
                    Combustible = table.Column<string>(nullable: true),
                    Ancho = table.Column<string>(nullable: true),
                    Largo = table.Column<string>(nullable: true),
                    Alto = table.Column<string>(nullable: true),
                    Uso = table.Column<string>(nullable: true),
                    Placas = table.Column<string>(nullable: true),
                    ItemModelNumber = table.Column<string>(nullable: true),
                    PhotoBusiness = table.Column<string>(nullable: true),
                    NumeroCamion = table.Column<int>(nullable: false),
                    ConductorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conductors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ConductorId = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    INE = table.Column<string>(nullable: true),
                    ComprobanteDomicilio = table.Column<string>(nullable: true),
                    LicenciaConducir = table.Column<string>(nullable: true),
                    SeguroSocial = table.Column<string>(nullable: true),
                    Fotografia = table.Column<string>(nullable: true),
                    VehiculoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conductors_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    IdSupervisor = table.Column<int>(nullable: false),
                    ProcesoRevisionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcesoRevisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Ruta = table.Column<string>(nullable: true),
                    horarioSupervision = table.Column<string>(nullable: true),
                    incidentes = table.Column<string>(nullable: true),
                    infoViajes = table.Column<string>(nullable: true),
                    SupervisorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcesoRevisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcesoRevisions_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conductors_VehiculoId",
                table: "Conductors",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcesoRevisions_SupervisorId",
                table: "ProcesoRevisions",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_ProcesoRevisionId",
                table: "Supervisors",
                column: "ProcesoRevisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ConductorId",
                table: "Vehiculos",
                column: "ConductorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Conductors_ConductorId",
                table: "Vehiculos",
                column: "ConductorId",
                principalTable: "Conductors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_ProcesoRevisions_ProcesoRevisionId",
                table: "Supervisors",
                column: "ProcesoRevisionId",
                principalTable: "ProcesoRevisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conductors_Vehiculos_VehiculoId",
                table: "Conductors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcesoRevisions_Supervisors_SupervisorId",
                table: "ProcesoRevisions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Conductors");

            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.DropTable(
                name: "ProcesoRevisions");
        }
    }
}
