﻿// <auto-generated />
using System;
using LabdarugoEredmenyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabdarugoEredmenyApp.Migrations
{
    [DbContext(typeof(LabdarugoEredmenyekContext))]
    partial class LabdarugoEredmenyekContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LabdarugoEredmenyApp.Models.Bajnoksag", b =>
                {
                    b.Property<Guid>("BajnoksagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BajnoksagNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("bit");

                    b.Property<string>("LogoBajnoksag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BajnoksagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CsapatNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DontetlenSzamlalo")
                        .HasColumnType("int");

                    b.Property<int>("GyozelemSzamlalo")
                        .HasColumnType("int");

                    b.Property<string>("LogoCsapat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VesztesSzamlalo")
                        .HasColumnType("int");

                    b.HasKey("CsapatId");

                    b.ToTable("Csapatok");

                    b.HasData(
                        new
                        {
                            CsapatId = new Guid("313317c9-6833-4cad-b8fe-796879447783"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Chelsea",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e1.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("28bfce0d-da42-416a-b09a-ea34bdbc18fb"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Aston Villa",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e4.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("276f22a0-ae36-4b12-80d7-dafbc0b266af"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Liverpool",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e5.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("ec61f010-5e89-4900-a85d-39499e901042"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Manchester United",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e7.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("c8d7a55f-1bf4-4200-a10d-3b51d37496a0"),
                            BajnoksagId = new Guid("3aab6379-74c5-4b28-8c5b-bc93ece03128"),
                            CsapatNev = "Manchester City",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/sco/thumb/e/eb/Manchester_City_FC_badge.svg/1024px-Manchester_City_FC_badge.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("0be05f01-471f-4fcb-9772-5c0d6325e6e5"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Vasas",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://seeklogo.com/images/V/vasas-sc-logo-7FC5081323-seeklogo.com.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("06982830-3471-49a9-88c5-2c0a1ef4db3b"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Ujpest",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/hu/c/c7/%C3%9Ajpest_FC_gold.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("097a62f8-d78c-4aa7-a499-0ae0f0ed5fcd"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Ferencvarosi TC",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://seeklogo.com/images/F/Fradi-logo-E674B9F1D6-seeklogo.com.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("68170836-264f-4462-9cdd-1049f0bc159a"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Puskas Akademia",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg/1200px-Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("05b3b065-e3ac-44b3-a5eb-192200327ceb"),
                            BajnoksagId = new Guid("8285a389-85ca-42a6-a331-1e8313284f14"),
                            CsapatNev = "Honved FC",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://seeklogo.com/images/K/kispest-honved-fc-logo-023C06A231-seeklogo.com.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("7bcdb1b4-b352-4d24-ac52-76a301944ec3"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Atletico Madrid",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://logos-world.net/wp-content/uploads/2020/06/atletico-madrid-Logo.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("0bf7a411-61e6-489b-a3af-3b7e5ee41ef0"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Valencia",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://logos-world.net/wp-content/uploads/2020/11/Valencia-Emblem.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("26460648-2c65-482f-a7b8-83673f7df698"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "FC Barcelona",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/584a9b3bb080d7616d298777.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("333cce0b-e7da-4f28-888d-b085264b461e"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Celta Vigo",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/RC_Celta_de_Vigo_logo.svg/800px-RC_Celta_de_Vigo_logo.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("1fc07d3c-87f8-4f46-80f9-eb4560a1c41b"),
                            BajnoksagId = new Guid("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),
                            CsapatNev = "Real Madrid",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://assets.stickpng.com/images/584a9b47b080d7616d298778.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("7e48ce27-38a5-430d-8d35-e047794eb4a1"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "AC Milan",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/361px-Logo_of_AC_Milan.svg.png?20201107091346",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("f0c1e099-8752-484b-a4d5-28a51b839d13"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "Juventus",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/d/da/Juventus_Logo.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("237fde59-6c14-4a9f-bafc-409f426adb4f"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "Inter",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Inter_Old_Logo_%282007-2014%29.svg/1491px-Inter_Old_Logo_%282007-2014%29.svg.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("e40833c0-8240-482b-b2e8-c1de51fdc31b"),
                            BajnoksagId = new Guid("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),
                            CsapatNev = "AS Roma",
                            DontetlenSzamlalo = 0,
                            GyozelemSzamlalo = 0,
                            LogoCsapat = "https://logos-world.net/wp-content/uploads/2020/06/Roma-Logo.png",
                            VesztesSzamlalo = 0
                        },
                        new
                        {
                            CsapatId = new Guid("0c16c279-e39e-4865-a14b-0656c2fe4a00"),
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
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BajnoksagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BajnoksagNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FelideiEredmeny")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HazaiCsapatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HazaiCsapatNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Idopont")
                        .HasColumnType("datetime2");

                    b.Property<string>("JegyzoKonyv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vegeredmeny")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VendegCsapatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VendegCsapatNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MerkozesId");

                    b.ToTable("Merkozesek");
                });
#pragma warning restore 612, 618
        }
    }
}