﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SuperMarketApp.Data;

namespace SuperMarketApp.Migrations
{
    [DbContext(typeof(SuperMarketContext))]
    partial class SuperMarketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SuperMarketApp.Models.Barang", b =>
                {
                    b.Property<int>("BarangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GudangID")
                        .HasColumnType("integer");

                    b.Property<decimal>("HargaBarang")
                        .HasColumnType("numeric");

                    b.Property<int>("JumlahBarang")
                        .HasColumnType("integer");

                    b.Property<string>("KodeBarang")
                        .HasColumnType("text");

                    b.Property<string>("NamaBarang")
                        .HasColumnType("text");

                    b.HasKey("BarangID");

                    b.HasIndex("GudangID");

                    b.ToTable("Barangs");
                });

            modelBuilder.Entity("SuperMarketApp.Models.Gudang", b =>
                {
                    b.Property<int>("GudangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NamaGudang")
                        .HasColumnType("text");

                    b.HasKey("GudangID");

                    b.ToTable("Gudangs");
                });

            modelBuilder.Entity("SuperMarketApp.Models.Barang", b =>
                {
                    b.HasOne("SuperMarketApp.Models.Gudang", "Gudang")
                        .WithMany("Barangs")
                        .HasForeignKey("GudangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gudang");
                });

            modelBuilder.Entity("SuperMarketApp.Models.Gudang", b =>
                {
                    b.Navigation("Barangs");
                });
#pragma warning restore 612, 618
        }
    }
}
