﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurfSessions_API.Data;

#nullable disable

namespace SurfSessions_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250703214752_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SurfSessions_API.Models.Forecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateTime")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<float>("Temperature")
                        .HasColumnType("float");

                    b.Property<int>("WaveDirection")
                        .HasColumnType("int");

                    b.Property<float>("WaveHeight")
                        .HasColumnType("float");

                    b.Property<float>("WavePeriod")
                        .HasColumnType("float");

                    b.Property<int>("WeatherCode")
                        .HasColumnType("int");

                    b.Property<int>("WindDirection")
                        .HasColumnType("int");

                    b.Property<float>("WindSpeed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Forecasts");
                });

            modelBuilder.Entity("SurfSessions_API.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("varchar(800)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ForecastId")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("SpotId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ForecastId");

                    b.HasIndex("SpotId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("SurfSessions_API.Models.Spot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Spots");
                });

            modelBuilder.Entity("SurfSessions_API.Models.Session", b =>
                {
                    b.HasOne("SurfSessions_API.Models.Forecast", "Forecast")
                        .WithMany()
                        .HasForeignKey("ForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurfSessions_API.Models.Spot", "Spot")
                        .WithMany("Sessions")
                        .HasForeignKey("SpotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Forecast");

                    b.Navigation("Spot");
                });

            modelBuilder.Entity("SurfSessions_API.Models.Spot", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
