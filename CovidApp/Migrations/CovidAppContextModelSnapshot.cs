﻿// <auto-generated />
using CovidApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CovidApp.Migrations
{
    [DbContext(typeof(CovidAppContext))]
    partial class CovidAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CovidApp.Models.AccessionRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccessionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessionVersion")
                        .HasColumnType("int");

                    b.Property<string>("CollectionDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orf1abSequence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orf3aSequence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurfaceGlycoproteinSequence")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessionRecord");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AccessionNumber = "MN908947",
                            AccessionVersion = 3,
                            CollectionDate = "DEC-2019",
                            Country = "CN",
                            Orf1abSequence = "AAAAAA",
                            Orf3aSequence = "AAAAAA",
                            Region = "Wuhan",
                            SurfaceGlycoproteinSequence = "AAAAAA"
                        },
                        new
                        {
                            Id = -2,
                            AccessionNumber = "MN988668",
                            AccessionVersion = 1,
                            CollectionDate = "02-Jan-2020",
                            Country = "CN",
                            Orf1abSequence = "AAAAAW",
                            Orf3aSequence = "AAAWWW",
                            SurfaceGlycoproteinSequence = "AAAAWA"
                        },
                        new
                        {
                            Id = -3,
                            AccessionNumber = "LC528232",
                            AccessionVersion = 1,
                            CollectionDate = "2020-02-10",
                            Country = "JP",
                            Orf1abSequence = "AAAAAA",
                            Orf3aSequence = "WAAWWA",
                            SurfaceGlycoproteinSequence = "AAAWAA"
                        },
                        new
                        {
                            Id = -4,
                            AccessionNumber = "MN988713",
                            AccessionVersion = 1,
                            CollectionDate = "21-Jan-2020",
                            Country = "US",
                            Orf1abSequence = "AWAWAW",
                            Orf3aSequence = "WWWAAA",
                            Region = "IL",
                            SurfaceGlycoproteinSequence = "AAAWWW"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
