using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SilverProcessingApp.Migrations.Silver
{
    public partial class SilverCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyingRawSilver",
                columns: table => new
                {
                    SilverCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawSilverQuantity = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    NoSilverUnits = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    GramsPerUnit = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    SilverValue = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    GST = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    SupplierName = table.Column<string>(type: "varchar(100)", nullable: false),
                    SupplierPhoneNo = table.Column<string>(type: "varchar(100)", nullable: false),
                    DateofPurchase = table.Column<DateTime>(type: "date", nullable: false),
                    Mass = table.Column<string>(type: "varchar(100)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ImageName2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ImageName3 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ImageName4 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ImageName5 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IPADDRESS = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PCNAME = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyingRawSilver", x => x.SilverCode);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "varchar(100)", nullable: false),
                    JobType = table.Column<string>(type: "varchar(100)", nullable: false),
                    Salary = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "ScrapSilverPurityConvertorJob",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNo = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    ExpectedfinalPurity = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    FromBuyer = table.Column<string>(type: "varchar(100)", nullable: true),
                    ToEndUser = table.Column<string>(type: "varchar(100)", nullable: true),
                    Dateofinput = table.Column<DateTime>(type: "date", nullable: false),
                    IPADDRESS = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PCNAME = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrapSilverPurityConvertorJob", x => x.Pid);
                });

            migrationBuilder.CreateTable(
                name: "SellOutDetails",
                columns: table => new
                {
                    SelloutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Soldby = table.Column<string>(type: "varchar(100)", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CustomerPhoneNo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Selloutdate = table.Column<DateTime>(type: "date", nullable: false),
                    Selloutvalue = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellOutDetails", x => x.SelloutId);
                });

            migrationBuilder.CreateTable(
                name: "SilverArticles",
                columns: table => new
                {
                    SilverArticleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeofSilverArticle = table.Column<string>(type: "varchar(100)", nullable: false),
                    DateofProcess = table.Column<DateTime>(type: "date", nullable: false),
                    Processby = table.Column<string>(type: "varchar(100)", nullable: false),
                    RawSilverQuantity = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    NetWeight = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    SilverValue = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    MakingCharges = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Wastage = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    GST = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SilverArticles", x => x.SilverArticleId);
                });

            migrationBuilder.CreateTable(
                name: "SupplierDetails",
                columns: table => new
                {
                    SupplierCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "varchar(100)", nullable: false),
                    SupplierPhoneNo = table.Column<string>(type: "varchar(100)", nullable: false),
                    QuantityBuyed = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    AmountPayed = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    OutstandingAmount = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDetails", x => x.SupplierCode);
                });

            migrationBuilder.CreateTable(
                name: "ScrapSilverPurityCalculatorJobDetails",
                columns: table => new
                {
                    SilverCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNumber = table.Column<int>(type: "int", nullable: false),
                    QuantityinGms = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    PercentageTomakepure = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    PureSilver = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    ExpectedfinalPurity = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    FinalPurity = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    FinalValue = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Pido = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    IPADDRESS = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PCNAME = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ScrapSilverPurityCalculatorJobDetailsSilverCode = table.Column<int>(nullable: true),
                    ScrapSilverPurityConvertorJobPid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrapSilverPurityCalculatorJobDetails", x => x.SilverCode);
                    table.ForeignKey(
                        name: "FK_ScrapSilverPurityCalculatorJobDetails_ScrapSilverPurityCalculatorJobDetails_ScrapSilverPurityCalculatorJobDetailsSilverCode",
                        column: x => x.ScrapSilverPurityCalculatorJobDetailsSilverCode,
                        principalTable: "ScrapSilverPurityCalculatorJobDetails",
                        principalColumn: "SilverCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScrapSilverPurityCalculatorJobDetails_ScrapSilverPurityConvertorJob_ScrapSilverPurityConvertorJobPid",
                        column: x => x.ScrapSilverPurityConvertorJobPid,
                        principalTable: "ScrapSilverPurityConvertorJob",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScrapSilverPurityCalculatorJobDetails_ScrapSilverPurityCalculatorJobDetailsSilverCode",
                table: "ScrapSilverPurityCalculatorJobDetails",
                column: "ScrapSilverPurityCalculatorJobDetailsSilverCode");

            migrationBuilder.CreateIndex(
                name: "IX_ScrapSilverPurityCalculatorJobDetails_ScrapSilverPurityConvertorJobPid",
                table: "ScrapSilverPurityCalculatorJobDetails",
                column: "ScrapSilverPurityConvertorJobPid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyingRawSilver");

            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "ScrapSilverPurityCalculatorJobDetails");

            migrationBuilder.DropTable(
                name: "SellOutDetails");

            migrationBuilder.DropTable(
                name: "SilverArticles");

            migrationBuilder.DropTable(
                name: "SupplierDetails");

            migrationBuilder.DropTable(
                name: "ScrapSilverPurityConvertorJob");
        }
    }
}
