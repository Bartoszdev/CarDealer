﻿// <auto-generated />
using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarDealer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181125212915_CarsChangingModel")]
    partial class CarsChangingModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarDealer.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<bool>("CarOfTheWeek");

                    b.Property<string>("Description");

                    b.Property<string>("EngineCapacity");

                    b.Property<string>("Fuel");

                    b.Property<bool>("InCentralStock");

                    b.Property<string>("Mileage");

                    b.Property<string>("Model");

                    b.Property<string>("Power");

                    b.Property<decimal>("Price");

                    b.Property<string>("UrlMiniature");

                    b.Property<string>("UrlPhoto");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
