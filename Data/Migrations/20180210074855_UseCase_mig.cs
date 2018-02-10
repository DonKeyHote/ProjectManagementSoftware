using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectManagementSoftware.Data.Migrations
{
    public partial class UseCase_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UseCase",
                columns: table => new
                {
                    UseCaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByEmpNum = table.Column<string>(maxLength: 6, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByEmpNum = table.Column<string>(maxLength: 6, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UseCaseDesc = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCase", x => x.UseCaseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UseCase");
        }
    }
}
