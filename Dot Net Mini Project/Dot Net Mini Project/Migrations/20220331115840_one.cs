using Microsoft.EntityFrameworkCore.Migrations;

namespace Dot_Net_Mini_Project.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "airpods",
                columns: table => new
                {
                    AirpodId = table.Column<int>(type: "int", nullable: false),
                    AirpodName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airpods", x => x.AirpodId);
                    table.ForeignKey(
                        name: "FK_airpods_users_AirpodId",
                        column: x => x.AirpodId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ipads",
                columns: table => new
                {
                    IpadId = table.Column<int>(type: "int", nullable: false),
                    IpadName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ipads", x => x.IpadId);
                    table.ForeignKey(
                        name: "FK_ipads_users_IpadId",
                        column: x => x.IpadId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "iphones",
                columns: table => new
                {
                    IphoneId = table.Column<int>(type: "int", nullable: false),
                    IphoneName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iphones", x => x.IphoneId);
                    table.ForeignKey(
                        name: "FK_iphones_users_IphoneId",
                        column: x => x.IphoneId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "iwatches",
                columns: table => new
                {
                    IwatchId = table.Column<int>(type: "int", nullable: false),
                    IwatchName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iwatches", x => x.IwatchId);
                    table.ForeignKey(
                        name: "FK_iwatches_users_IwatchId",
                        column: x => x.IwatchId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "airpods");

            migrationBuilder.DropTable(
                name: "ipads");

            migrationBuilder.DropTable(
                name: "iphones");

            migrationBuilder.DropTable(
                name: "iwatches");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
