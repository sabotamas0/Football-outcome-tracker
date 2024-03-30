﻿// <auto-generated />
using System;
using LabdarugoEredmenyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabdarugoEredmenyApp.Migrations
{
    [DbContext(typeof(LabdarugoEredmenyekContext))]
    [Migration("20240330180116_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LabdarugoEredmenyApp.Models.Bajnoksag", b =>
                {
                    b.Property<Guid>("BajnoksagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<string>("BajnoksagNev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LogoBajnoksag")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BajnoksagId");

                    b.ToTable("Bajnoksagok");

                    b.HasData(
                        new
                        {
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            BajnoksagNev = "Premier League",
                            IsFavourite = false,
                            LogoBajnoksag = "https://cdn.freebiesupply.com/images/large/2x/premier-league-logo-black-and-white.png"
                        },
                        new
                        {
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            BajnoksagNev = "OTP Bank Liga",
                            IsFavourite = false,
                            LogoBajnoksag = "https://upload.wikimedia.org/wikipedia/commons/9/96/OTP_Bank_Liga_logo.png"
                        },
                        new
                        {
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            BajnoksagNev = "La liga",
                            IsFavourite = false,
                            LogoBajnoksag = "https://assets.laliga.com/assets/logos/laliga-h/laliga-h-1200x1200.png"
                        },
                        new
                        {
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            BajnoksagNev = "Serie A",
                            IsFavourite = false,
                            LogoBajnoksag = "https://upload.wikimedia.org/wikipedia/commons/c/c2/Serie_A.png"
                        });
                });

            modelBuilder.Entity("LabdarugoEredmenyApp.Models.Csapat", b =>
                {
                    b.Property<Guid>("CsapatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<Guid>("BajnoksagId")
                        .HasColumnType("binary(16)");

                    b.Property<string>("CsapatNev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DontetlenSzamlalo")
                        .HasColumnType("int");

                    b.Property<int>("GyozelemSzamlalo")
                        .HasColumnType("int");

                    b.Property<string>("LogoCsapat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VesztesSzamlalo")
                        .HasColumnType("int");

                    b.HasKey("CsapatId");

                    b.ToTable("Csapatok");

                    b.HasData(
                        new
                        {
                            CsapatId = new Guid("15000579-f26f-45c0-ad0a-10e29758927c"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Chelsea",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e1.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("f0642cd0-289b-4f0b-925e-2cea2ad65a26"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Aston Villa",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e4.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("8ffe0951-9a10-467c-9698-9dd39359394f"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Liverpool",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e5.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("2bd3e1e4-1d37-40d7-934e-6eef4c78f7eb"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Manchester United",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e7.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("57535054-b6e6-4cc3-89d2-43f15db50a62"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Manchester City",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/sco/thumb/e/eb/Manchester_City_FC_badge.svg/1024px-Manchester_City_FC_badge.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("d3fc6c22-1059-4dba-8b5f-c0e3c32d0a32"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Vasas",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://seeklogo.com/images/V/vasas-sc-logo-7FC5081323-seeklogo.com.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("a9aafacb-80f1-46f8-b344-74130b98bcba"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Ujpest",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/hu/c/c7/%C3%9Ajpest_FC_gold.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("af388391-682a-4002-9e63-12c8d225bae5"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Ferencvarosi TC",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://seeklogo.com/images/F/Fradi-logo-E674B9F1D6-seeklogo.com.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("68fc6661-3c73-4592-9f16-b903b6f5f12b"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Puskas Akademia",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg/1200px-Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("44b4ba3e-d621-4677-a94a-fbe32c13f114"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Honved FC",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://seeklogo.com/images/K/kispest-honved-fc-logo-023C06A231-seeklogo.com.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("a9a691a0-a7a8-46de-9202-e5696e6344ea"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Atletico Madrid",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://logos-world.net/wp-content/uploads/2020/06/atletico-madrid-Logo.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("9ea2f28d-5429-45bf-bb98-2b30419b96c2"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Valencia",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://logos-world.net/wp-content/uploads/2020/11/Valencia-Emblem.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("04cc3107-cd12-4a2b-a6ae-4adaf09c4f9d"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "FC Barcelona",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/584a9b3bb080d7616d298777.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("41769627-cdc7-40cb-8416-172acaa91a82"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Celta Vigo",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/RC_Celta_de_Vigo_logo.svg/800px-RC_Celta_de_Vigo_logo.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("d0b931c6-0e03-4df6-a0e0-851a2db95b25"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Real Madrid",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/584a9b47b080d7616d298778.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("41af333c-2954-4c45-9fcf-94fd15afb824"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "AC Milan",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/361px-Logo_of_AC_Milan.svg.png?20201107091346",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("51c80838-b680-48d4-bc19-e96f8dfeae3c"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "Juventus",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/d/da/Juventus_Logo.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("ba43f21f-5cb0-46cd-b7a7-5275b09d8007"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "Inter",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Inter_Old_Logo_%282007-2014%29.svg/1491px-Inter_Old_Logo_%282007-2014%29.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("56558767-7151-45ba-a7e6-4b5072b5a235"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "AS Roma",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://logos-world.net/wp-content/uploads/2020/06/Roma-Logo.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("fcfea456-4b9f-48c7-b8cc-b207ca2da81e"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "Napoli",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Logo_SSD_Napoli_Femminile_%282018%29.png/769px-Logo_SSD_Napoli_Femminile_%282018%29.png",
                            VesztesSzamlalo = 0
                        });
                });

            modelBuilder.Entity("LabdarugoEredmenyApp.Models.Merkozes", b =>
                {
                    b.Property<Guid>("MerkozesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("binary(16)");

                    b.Property<Guid>("BajnoksagId")
                        .HasColumnType("binary(16)");

                    b.Property<string>("BajnoksagNev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FelideiEredmeny")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("HazaiCsapatId")
                        .HasColumnType("binary(16)");

                    b.Property<string>("HazaiCsapatNev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Idopont")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("JegyzoKonyv")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Vegeredmeny")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("VendegCsapatId")
                        .HasColumnType("binary(16)");

                    b.Property<string>("VendegCsapatNev")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MerkozesId");

                    b.ToTable("Merkozesek");
                });
#pragma warning restore 612, 618
        }
    }
}
