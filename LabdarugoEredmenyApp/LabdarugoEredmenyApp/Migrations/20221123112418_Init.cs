using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabdarugoEredmenyApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bajnoksagok",
                columns: table => new
                {
                    BajnoksagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BajnoksagNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFavourite = table.Column<bool>(type: "bit", nullable: false),
                    LogoBajnoksag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bajnoksagok", x => x.BajnoksagId);
                });

            migrationBuilder.CreateTable(
                name: "Csapatok",
                columns: table => new
                {
                    CsapatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CsapatNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GyozelemSzamlalo = table.Column<int>(type: "int", nullable: false),
                    VesztesSzamlalo = table.Column<int>(type: "int", nullable: false),
                    DontetlenSzamlalo = table.Column<int>(type: "int", nullable: false),
                    BajnoksagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogoCsapat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Csapatok", x => x.CsapatId);
                });

            migrationBuilder.CreateTable(
                name: "Merkozesek",
                columns: table => new
                {
                    MerkozesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idopont = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vegeredmeny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FelideiEredmeny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JegyzoKonyv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HazaiCsapatNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendegCsapatNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HazaiCsapatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendegCsapatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BajnoksagNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BajnoksagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merkozesek", x => x.MerkozesId);
                });

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
                    { new Guid("05b3b065-e3ac-44b3-a5eb-192200327ceb"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Honved FC", 0, 0, "https://seeklogo.com/images/K/kispest-honved-fc-logo-023C06A231-seeklogo.com.png", 0 },
                    { new Guid("06982830-3471-49a9-88c5-2c0a1ef4db3b"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Ujpest", 0, 0, "https://upload.wikimedia.org/wikipedia/hu/c/c7/%C3%9Ajpest_FC_gold.png", 0 },
                    { new Guid("097a62f8-d78c-4aa7-a499-0ae0f0ed5fcd"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Ferencvarosi TC", 0, 0, "https://seeklogo.com/images/F/Fradi-logo-E674B9F1D6-seeklogo.com.png", 0 },
                    { new Guid("0be05f01-471f-4fcb-9772-5c0d6325e6e5"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Vasas", 0, 0, "https://seeklogo.com/images/V/vasas-sc-logo-7FC5081323-seeklogo.com.png", 0 },
                    { new Guid("0bf7a411-61e6-489b-a3af-3b7e5ee41ef0"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Valencia", 0, 0, "https://logos-world.net/wp-content/uploads/2020/11/Valencia-Emblem.png", 0 },
                    { new Guid("0c16c279-e39e-4865-a14b-0656c2fe4a00"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Napoli", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Logo_SSD_Napoli_Femminile_%282018%29.png/769px-Logo_SSD_Napoli_Femminile_%282018%29.png", 0 },
                    { new Guid("1fc07d3c-87f8-4f46-80f9-eb4560a1c41b"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Real Madrid", 0, 0, "https://assets.stickpng.com/images/584a9b47b080d7616d298778.png", 0 },
                    { new Guid("237fde59-6c14-4a9f-bafc-409f426adb4f"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Inter", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Inter_Old_Logo_%282007-2014%29.svg/1491px-Inter_Old_Logo_%282007-2014%29.svg.png", 0 },
                    { new Guid("26460648-2c65-482f-a7b8-83673f7df698"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "FC Barcelona", 0, 0, "https://assets.stickpng.com/images/584a9b3bb080d7616d298777.png", 0 },
                    { new Guid("276f22a0-ae36-4b12-80d7-dafbc0b266af"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Liverpool", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e5.png", 0 },
                    { new Guid("28bfce0d-da42-416a-b09a-ea34bdbc18fb"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Aston Villa", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e4.png", 0 },
                    { new Guid("313317c9-6833-4cad-b8fe-796879447783"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Chelsea", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e1.png", 0 },
                    { new Guid("333cce0b-e7da-4f28-888d-b085264b461e"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Celta Vigo", 0, 0, "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/RC_Celta_de_Vigo_logo.svg/800px-RC_Celta_de_Vigo_logo.svg.png", 0 },
                    { new Guid("68170836-264f-4462-9cdd-1049f0bc159a"), new Guid("8285a389-85ca-42a6-a331-1e8313284f14"), "Puskas Akademia", 0, 0, "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg/1200px-Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg.png", 0 },
                    { new Guid("7bcdb1b4-b352-4d24-ac52-76a301944ec3"), new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), "Atletico Madrid", 0, 0, "https://logos-world.net/wp-content/uploads/2020/06/atletico-madrid-Logo.png", 0 },
                    { new Guid("7e48ce27-38a5-430d-8d35-e047794eb4a1"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "AC Milan", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/361px-Logo_of_AC_Milan.svg.png?20201107091346", 0 },
                    { new Guid("c8d7a55f-1bf4-4200-a10d-3b51d37496a0"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Manchester City", 0, 0, "https://upload.wikimedia.org/wikipedia/sco/thumb/e/eb/Manchester_City_FC_badge.svg/1024px-Manchester_City_FC_badge.svg.png", 0 },
                    { new Guid("e40833c0-8240-482b-b2e8-c1de51fdc31b"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "AS Roma", 0, 0, "https://logos-world.net/wp-content/uploads/2020/06/Roma-Logo.png", 0 },
                    { new Guid("ec61f010-5e89-4900-a85d-39499e901042"), new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"), "Manchester United", 0, 0, "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e7.png", 0 },
                    { new Guid("f0c1e099-8752-484b-a4d5-28a51b839d13"), new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), "Juventus", 0, 0, "https://upload.wikimedia.org/wikipedia/commons/d/da/Juventus_Logo.png", 0 }
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
