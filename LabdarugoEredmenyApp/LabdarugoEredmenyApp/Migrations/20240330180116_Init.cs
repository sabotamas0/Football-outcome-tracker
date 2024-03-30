using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabdarugoEredmenyApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bajnoksagok",
                columns: table => new
                {
                    BajnoksagId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    BajnoksagNev = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsFavourite = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LogoBajnoksag = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bajnoksagok", x => x.BajnoksagId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Csapatok",
                columns: table => new
                {
                    CsapatId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    CsapatNev = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GyozelemSzamlalo = table.Column<int>(type: "int", nullable: false),
                    VesztesSzamlalo = table.Column<int>(type: "int", nullable: false),
                    DontetlenSzamlalo = table.Column<int>(type: "int", nullable: false),
                    BajnoksagId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    LogoCsapat = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Csapatok", x => x.CsapatId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Merkozesek",
                columns: table => new
                {
                    MerkozesId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    Idopont = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Vegeredmeny = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FelideiEredmeny = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JegyzoKonyv = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HazaiCsapatNev = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VendegCsapatNev = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HazaiCsapatId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    VendegCsapatId = table.Column<Guid>(type: "binary(16)", nullable: false),
                    BajnoksagNev = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BajnoksagId = table.Column<Guid>(type: "binary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merkozesek", x => x.MerkozesId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Bajnoksagok",
                columns: new[] { "BajnoksagId", "BajnoksagNev", "IsFavourite", "LogoBajnoksag" },
                values: new object[,]
                {
                    { new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "La liga", false, "https://assets.laliga.com/assets/logos/laliga-h/laliga-h-1200x1200.png" },
                    { new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Premier League", false, "https://cdn.freebiesupply.com/images/large/2x/premier-league-logo-black-and-white.png" },
                    { new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "OTP Bank Liga", false, "https://upload.wikimedia.org/wikipedia/commons/9/96/OTP_Bank_Liga_logo.png" },
                    { new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Serie A", false, "https://upload.wikimedia.org/wikipedia/commons/c/c2/Serie_A.png" }
                });

            migrationBuilder.InsertData(
                table: "Csapatok",
                columns: new[] { "CsapatId", "BajnoksagId", "CsapatNev", "DontetlenSzamlalo", "GyozelemSzamlalo", "LogoCsapat", "VesztesSzamlalo" },
                values: new object[,]
                {
                    { new Guid("04cc3107-cd12-4a2b-a6ae-4adaf09c4f9d"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "FC Barcelona", 0, 0, "https://assets.stickpng.com/images/584a9b3bb080d7616d298777.png", 0 },
                    { new Guid("15000579-f26f-45c0-ad0a-10e29758927c"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Chelsea", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e1.png", 0 },
                    { new Guid("2bd3e1e4-1d37-40d7-934e-6eef4c78f7eb"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Manchester United", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e7.png", 0 },
                    { new Guid("41769627-cdc7-40cb-8416-172acaa91a82"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Celta Vigo", 0, 0, "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/RC_Celta_de_Vigo_logo.svg/800px-RC_Celta_de_Vigo_logo.svg.png", 0 },
                    { new Guid("41af333c-2954-4c45-9fcf-94fd15afb824"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "AC Milan", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/361px-Logo_of_AC_Milan.svg.png?20201107091346", 0 },
                    { new Guid("44b4ba3e-d621-4677-a94a-fbe32c13f114"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Honved FC", 0, 0, "https://seeklogo.com/images/K/kispest-honved-fc-logo-023C06A231-seeklogo.com.png", 0 },
                    { new Guid("51c80838-b680-48d4-bc19-e96f8dfeae3c"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Juventus", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/d/da/Juventus_Logo.png", 0 },
                    { new Guid("56558767-7151-45ba-a7e6-4b5072b5a235"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "AS Roma", 0, 0, "https://logos-world.net/wp-content/uploads/2020/06/Roma-Logo.png", 0 },
                    { new Guid("57535054-b6e6-4cc3-89d2-43f15db50a62"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Manchester City", 0, 0, "https://upload.wikimedia.org/wikipedia/sco/thumb/e/eb/Manchester_City_FC_badge.svg/1024px-Manchester_City_FC_badge.svg.png", 0 },
                    { new Guid("68fc6661-3c73-4592-9f16-b903b6f5f12b"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Puskas Akademia", 0, 0, "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg/1200px-Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg.png", 0 },
                    { new Guid("8ffe0951-9a10-467c-9698-9dd39359394f"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Liverpool", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e5.png", 0 },
                    { new Guid("9ea2f28d-5429-45bf-bb98-2b30419b96c2"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Valencia", 0, 0, "https://logos-world.net/wp-content/uploads/2020/11/Valencia-Emblem.png", 0 },
                    { new Guid("a9a691a0-a7a8-46de-9202-e5696e6344ea"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Atletico Madrid", 0, 0, "https://logos-world.net/wp-content/uploads/2020/06/atletico-madrid-Logo.png", 0 },
                    { new Guid("a9aafacb-80f1-46f8-b344-74130b98bcba"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Ujpest", 0, 0, "https://upload.wikimedia.org/wikipedia/hu/c/c7/%C3%9Ajpest_FC_gold.png", 0 },
                    { new Guid("af388391-682a-4002-9e63-12c8d225bae5"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Ferencvarosi TC", 0, 0, "https://seeklogo.com/images/F/Fradi-logo-E674B9F1D6-seeklogo.com.png", 0 },
                    { new Guid("ba43f21f-5cb0-46cd-b7a7-5275b09d8007"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Inter", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Inter_Old_Logo_%282007-2014%29.svg/1491px-Inter_Old_Logo_%282007-2014%29.svg.png", 0 },
                    { new Guid("d0b931c6-0e03-4df6-a0e0-851a2db95b25"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Real Madrid", 0, 0, "https://assets.stickpng.com/images/584a9b47b080d7616d298778.png", 0 },
                    { new Guid("d3fc6c22-1059-4dba-8b5f-c0e3c32d0a32"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Vasas", 0, 0, "https://seeklogo.com/images/V/vasas-sc-logo-7FC5081323-seeklogo.com.png", 0 },
                    { new Guid("f0642cd0-289b-4f0b-925e-2cea2ad65a26"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Aston Villa", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e4.png", 0 },
                    { new Guid("fcfea456-4b9f-48c7-b8cc-b207ca2da81e"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Napoli", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Logo_SSD_Napoli_Femminile_%282018%29.png/769px-Logo_SSD_Napoli_Femminile_%282018%29.png", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bajnoksagok");

            migrationBuilder.DropTable(
                name: "Csapatok");

            migrationBuilder.DropTable(
                name: "Merkozesek");
        }
    }
}
