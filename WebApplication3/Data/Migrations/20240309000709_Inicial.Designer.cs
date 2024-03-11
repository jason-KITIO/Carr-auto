﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

#nullable disable

namespace WebApplication3.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240309000709_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApplication3.Models.devis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("iDFreins")
                        .HasColumnType("int");

                    b.Property<int>("iDPneus")
                        .HasColumnType("int");

                    b.Property<int>("iDReparation")
                        .HasColumnType("int");

                    b.Property<int>("iDVoiture")
                        .HasColumnType("int");

                    b.Property<int>("iDbatteries")
                        .HasColumnType("int");

                    b.Property<int>("iDgentes")
                        .HasColumnType("int");

                    b.Property<int>("iDmainsOeuvres")
                        .HasColumnType("int");

                    b.Property<int>("iDmoteurs")
                        .HasColumnType("int");

                    b.Property<int>("iDroue")
                        .HasColumnType("int");

                    b.Property<int>("iDsuspensions")
                        .HasColumnType("int");

                    b.Property<int>("iDturboCompresseur")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("devis");
                });

            modelBuilder.Entity("WebApplication3.Models.NombreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nombres");
                });

            modelBuilder.Entity("WebApplication3.Models.Pneu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Pneu");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.batterie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marque")
                        .HasColumnType("int");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("batteries");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.freins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marque")
                        .HasColumnType("int");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("freins");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.moteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marque")
                        .HasColumnType("int");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("moteurs");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.Suspension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marque")
                        .HasColumnType("int");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("suspensions");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.TurboCompresseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marque")
                        .HasColumnType("int");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("turboCompresseur");
                });

            modelBuilder.Entity("WebApplication3.Models.Reparation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("categorie")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.Property<bool>("statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("reparations");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.Gentes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PneuId")
                        .HasColumnType("int");

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PneuId");

                    b.HasIndex("devisId");

                    b.ToTable("gentes");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.MainsOeuvre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PneuId")
                        .HasColumnType("int");

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PneuId");

                    b.HasIndex("devisId");

                    b.ToTable("mainsOeuvres");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.Pneus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PneuId")
                        .HasColumnType("int");

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PneuId");

                    b.HasIndex("devisId");

                    b.ToTable("pneus");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.Roue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PneuId")
                        .HasColumnType("int");

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PneuId");

                    b.HasIndex("devisId");

                    b.ToTable("roue");
                });

            modelBuilder.Entity("WebApplication3.Models.Voiture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("categorie")
                        .HasColumnType("int");

                    b.Property<int?>("devisId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("devisId");

                    b.ToTable("voitures");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.batterie", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("batteries")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.freins", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("freins")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.moteur", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("moteurs")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.Suspension", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("suspensions")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.Produits.TurboCompresseur", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("turboCompresseur")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.Reparation", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("reparations")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.Gentes", b =>
                {
                    b.HasOne("WebApplication3.Models.Pneu", null)
                        .WithMany("gentes")
                        .HasForeignKey("PneuId");

                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("gentes")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.MainsOeuvre", b =>
                {
                    b.HasOne("WebApplication3.Models.Pneu", null)
                        .WithMany("mainsOeuvres")
                        .HasForeignKey("PneuId");

                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("mainsOeuvres")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.Pneus", b =>
                {
                    b.HasOne("WebApplication3.Models.Pneu", null)
                        .WithMany("Pneus")
                        .HasForeignKey("PneuId");

                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("Pneus")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.roue.Roue", b =>
                {
                    b.HasOne("WebApplication3.Models.Pneu", null)
                        .WithMany("roue")
                        .HasForeignKey("PneuId");

                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("roue")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.Voiture", b =>
                {
                    b.HasOne("WebApplication3.Models.devis", null)
                        .WithMany("Voiture")
                        .HasForeignKey("devisId");
                });

            modelBuilder.Entity("WebApplication3.Models.devis", b =>
                {
                    b.Navigation("Pneus");

                    b.Navigation("Voiture");

                    b.Navigation("batteries");

                    b.Navigation("freins");

                    b.Navigation("gentes");

                    b.Navigation("mainsOeuvres");

                    b.Navigation("moteurs");

                    b.Navigation("reparations");

                    b.Navigation("roue");

                    b.Navigation("suspensions");

                    b.Navigation("turboCompresseur");
                });

            modelBuilder.Entity("WebApplication3.Models.Pneu", b =>
                {
                    b.Navigation("Pneus");

                    b.Navigation("gentes");

                    b.Navigation("mainsOeuvres");

                    b.Navigation("roue");
                });
#pragma warning restore 612, 618
        }
    }
}
