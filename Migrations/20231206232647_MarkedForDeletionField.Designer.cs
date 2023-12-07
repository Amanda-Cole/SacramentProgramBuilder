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
    [Migration("20231206232647_MarkedForDeletionField")]
    partial class MarkedForDeletionField
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClosingHymnNum")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ClosingPrayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateHymnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IntermediateHymnNum")
                        .HasColumnType("int");

                    b.Property<string>("OpeningHymnName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpeningHymnNum")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("OpeningPrayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresidingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProgramDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SacramentHymnName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SacramentHymnNum")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("SpecialMusicalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SacramentProgram");
                });

            modelBuilder.Entity("SacramentProgramBuilder.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("MarkedForDeletion")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SacramentProgramId")
                        .HasColumnType("int");

                    b.Property<string>("SpeakerType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SacramentProgramId");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("SacramentProgramBuilder.Models.Speaker", b =>
                {
                    b.HasOne("SacramentProgramBuilder.Models.SacramentProgram", null)
                        .WithMany("Speakers")
                        .HasForeignKey("SacramentProgramId");
                });

            modelBuilder.Entity("SacramentProgramBuilder.Models.SacramentProgram", b =>
                {
                    b.Navigation("Speakers");
                });
#pragma warning restore 612, 618
        }
    }
}
