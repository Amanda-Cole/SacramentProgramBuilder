﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentProgramBuilder.Data;

#nullable disable

namespace SacramentProgramBuilder.Migrations
{
    [DbContext(typeof(SacramentProgramBuilderContext))]
    [Migration("20231205043226_ProgramDate")]
    partial class ProgramDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SacramentProgramBuilder.Models.SacramentProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClosingHymnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClosingHymnNum")
                        .HasColumnType("int");

                    b.Property<string>("ClosingPrayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateHymnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IntermediateHymnNum")
                        .HasColumnType("int");

                    b.Property<string>("OpeningHymnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpeningHymnNum")
                        .HasColumnType("int");

                    b.Property<string>("OpeningPrayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresidingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProgramDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SacramentHymnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SacramentHymnNum")
                        .HasColumnType("int");

                    b.Property<string>("SpeakerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeakerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialMusicalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SacramentProgram");
                });
#pragma warning restore 612, 618
        }
    }
}
