using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModulosMaestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreModulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulosMaestros", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PermisosGenericos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePermiso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosGenericos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubModulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreSubModulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubModulos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolVsMaestro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "date", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdMaestro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolVsMaestro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolVsMaestro_ModulosMaestros_IdMaestro",
                        column: x => x.IdMaestro,
                        principalTable: "ModulosMaestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolVsMaestro_Rol_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaestrosVsSubmodulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "date", nullable: false),
                    IdMaestro = table.Column<int>(type: "int", nullable: false),
                    IdSubModulo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaestrosVsSubmodulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaestrosVsSubmodulos_ModulosMaestros_IdMaestro",
                        column: x => x.IdMaestro,
                        principalTable: "ModulosMaestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaestrosVsSubmodulos_SubModulos_IdSubModulo",
                        column: x => x.IdSubModulo,
                        principalTable: "SubModulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GenericosVsSubmodulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "date", nullable: false),
                    IdGenericos = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdSubModulos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericosVsSubmodulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericosVsSubmodulos_MaestrosVsSubmodulos_IdSubModulos",
                        column: x => x.IdSubModulos,
                        principalTable: "MaestrosVsSubmodulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericosVsSubmodulos_PermisosGenericos_IdGenericos",
                        column: x => x.IdGenericos,
                        principalTable: "PermisosGenericos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericosVsSubmodulos_Rol_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GenericosVsSubmodulos_IdGenericos",
                table: "GenericosVsSubmodulos",
                column: "IdGenericos");

            migrationBuilder.CreateIndex(
                name: "IX_GenericosVsSubmodulos_IdRol",
                table: "GenericosVsSubmodulos",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_GenericosVsSubmodulos_IdSubModulos",
                table: "GenericosVsSubmodulos",
                column: "IdSubModulos");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosVsSubmodulos_IdMaestro",
                table: "MaestrosVsSubmodulos",
                column: "IdMaestro");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosVsSubmodulos_IdSubModulo",
                table: "MaestrosVsSubmodulos",
                column: "IdSubModulo");

            migrationBuilder.CreateIndex(
                name: "IX_RolVsMaestro_IdMaestro",
                table: "RolVsMaestro",
                column: "IdMaestro");

            migrationBuilder.CreateIndex(
                name: "IX_RolVsMaestro_IdRol",
                table: "RolVsMaestro",
                column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenericosVsSubmodulos");

            migrationBuilder.DropTable(
                name: "RolVsMaestro");

            migrationBuilder.DropTable(
                name: "MaestrosVsSubmodulos");

            migrationBuilder.DropTable(
                name: "PermisosGenericos");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "ModulosMaestros");

            migrationBuilder.DropTable(
                name: "SubModulos");
        }
    }
}
