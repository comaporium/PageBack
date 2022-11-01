using Microsoft.EntityFrameworkCore.Migrations;

namespace PageBE.Migrations
{
    public partial class PageBaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    kursId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKursa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.kursId);
                });

            migrationBuilder.CreateTable(
                name: "statusStudentas",
                columns: table => new
                {
                    statusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivStatusa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusStudentas", x => x.statusId);
                });

            migrationBuilder.CreateTable(
                name: "Studentis",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojIndexa = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Godina = table.Column<int>(type: "int", nullable: false),
                    statusId = table.Column<int>(type: "int", nullable: false),
                    StatusStudentastatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentis", x => x.studentId);
                    table.ForeignKey(
                        name: "FK_Studentis_statusStudentas_StatusStudentastatusId",
                        column: x => x.StatusStudentastatusId,
                        principalTable: "statusStudentas",
                        principalColumn: "statusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KursStudentas",
                columns: table => new
                {
                    kursStudentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    kursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursStudentas", x => x.kursStudentaId);
                    table.ForeignKey(
                        name: "FK_KursStudentas_Kurs_kursId",
                        column: x => x.kursId,
                        principalTable: "Kurs",
                        principalColumn: "kursId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KursStudentas_Studentis_studentId",
                        column: x => x.studentId,
                        principalTable: "Studentis",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kurs",
                columns: new[] { "kursId", "NazivKursa" },
                values: new object[,]
                {
                    { 1, "Spanski jezik" },
                    { 2, "JWT Kurs" },
                    { 3, "Udemy C#" },
                    { 4, "Engleski jezik" },
                    { 5, "Njemacki jezik" }
                });

            migrationBuilder.InsertData(
                table: "Studentis",
                columns: new[] { "studentId", "Godina", "Ime", "Prezime", "StatusStudentastatusId", "brojIndexa", "statusId" },
                values: new object[,]
                {
                    { 1, 2, "Ivan", "Krakan", null, 8180, 1 },
                    { 2, 3, "Mujo", "Mujic", null, 4144, 1 },
                    { 3, 1, "Marija", "Stanojevic", null, 5432, 2 },
                    { 4, 3, "Kenan", "Huremovic", null, 7564, 1 },
                    { 5, 3, "Lamija", "Krso", null, 3245, 2 }
                });

            migrationBuilder.InsertData(
                table: "statusStudentas",
                columns: new[] { "statusId", "NazivStatusa" },
                values: new object[,]
                {
                    { 1, "Redovan" },
                    { 2, "Vanredan" }
                });

            migrationBuilder.InsertData(
                table: "KursStudentas",
                columns: new[] { "kursStudentaId", "kursId", "studentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 5, 1 },
                    { 3, 2, 2 },
                    { 4, 3, 2 },
                    { 5, 2, 2 },
                    { 6, 3, 3 },
                    { 7, 5, 4 },
                    { 8, 3, 4 },
                    { 11, 2, 4 },
                    { 9, 5, 5 },
                    { 10, 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KursStudentas_kursId",
                table: "KursStudentas",
                column: "kursId");

            migrationBuilder.CreateIndex(
                name: "IX_KursStudentas_studentId",
                table: "KursStudentas",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Studentis_StatusStudentastatusId",
                table: "Studentis",
                column: "StatusStudentastatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KursStudentas");

            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Studentis");

            migrationBuilder.DropTable(
                name: "statusStudentas");
        }
    }
}
