using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.Infrastructure.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    CPUId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPUName = table.Column<string>(name: "CPU Name", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.CPUId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystem",
                columns: table => new
                {
                    MyOperatingSystemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatingSystemName = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystem", x => x.MyOperatingSystemId);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhone",
                columns: table => new
                {
                    MobilePhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Size = table.Column<string>(maxLength: 32, nullable: false),
                    Weight = table.Column<string>(maxLength: 32, nullable: false),
                    ScreenSizeAndResolution = table.Column<string>(maxLength: 32, nullable: false),
                    Memory = table.Column<string>(nullable: true),
                    PicturesAndVideosUrlOrPath = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CPUId = table.Column<int>(nullable: false),
                    MyOperatingSystemId = table.Column<int>(nullable: false),
                    ManufacturerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhone", x => x.MobilePhoneId);
                    table.ForeignKey(
                        name: "FK_MobilePhone_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "CPUId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobilePhone_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobilePhone_OperatingSystem_MyOperatingSystemId",
                        column: x => x.MyOperatingSystemId,
                        principalTable: "OperatingSystem",
                        principalColumn: "MyOperatingSystemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhone_CPUId",
                table: "MobilePhone",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhone_ManufacturerId",
                table: "MobilePhone",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhone_MyOperatingSystemId",
                table: "MobilePhone",
                column: "MyOperatingSystemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobilePhone");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "OperatingSystem");
        }
    }
}
