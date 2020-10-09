﻿// <auto-generated />
using Frontend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Frontend.Migrations
{
    [DbContext(typeof(KankammisinContext))]
    partial class KankammisinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Frontend.Models.TestModel", b =>
                {
                    b.Property<string>("TestId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TestAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestCozulmeSayisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestLinki")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestSahibi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestSoruSayisi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("Testler");
                });
#pragma warning restore 612, 618
        }
    }
}