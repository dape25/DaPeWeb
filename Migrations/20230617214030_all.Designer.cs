﻿// <auto-generated />
using DaPe.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DaPe.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230617214030_all")]
    partial class all
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DaPe.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayCategoryNr")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayCategoryNr = 1,
                            Name = "Plyn"
                        },
                        new
                        {
                            Id = 2,
                            DisplayCategoryNr = 2,
                            Name = "Voda"
                        },
                        new
                        {
                            Id = 3,
                            DisplayCategoryNr = 3,
                            Name = "Elektrika"
                        });
                });

            modelBuilder.Entity("DaPe.Models.KindOfProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayTypeOfProductNr")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfProduct")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayTypeOfProductNr = 1,
                            TypeOfProduct = "Hlavní měřidlo"
                        },
                        new
                        {
                            Id = 2,
                            DisplayTypeOfProductNr = 2,
                            TypeOfProduct = "Podružné měřidlo"
                        },
                        new
                        {
                            Id = 3,
                            DisplayTypeOfProductNr = 3,
                            TypeOfProduct = "Dopočtené měřidlo"
                        });
                });

            modelBuilder.Entity("DaPe.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayProductNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KindOfProductId")
                        .HasColumnType("int");

                    b.Property<string>("NameOfProduct")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("KindOfProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Hlavní vodoměr venku za zámečkem",
                            DisplayProductNr = "Doplň číslo měřáku",
                            ImageUrl = "",
                            KindOfProductId = 1,
                            NameOfProduct = "Vodoměr hlavní"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Rozvodna vody na středisku 320 - dveře č. - ???",
                            DisplayProductNr = "Doplň číslo měřáku",
                            ImageUrl = "",
                            KindOfProductId = 1,
                            NameOfProduct = "Vodoměr - budova 7"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Umístění - dole v rozvodně budovy M24 dveře č. ???",
                            DisplayProductNr = "Doplň číslo měřáku",
                            ImageUrl = "",
                            KindOfProductId = 1,
                            NameOfProduct = "Vodoměr-M24-dole"
                        });
                });

            modelBuilder.Entity("DaPe.Models.Product", b =>
                {
                    b.HasOne("DaPe.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DaPe.Models.KindOfProduct", "KindOfProduct")
                        .WithMany()
                        .HasForeignKey("KindOfProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("KindOfProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
