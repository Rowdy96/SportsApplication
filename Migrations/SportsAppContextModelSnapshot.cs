﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsApp.Models;

namespace SportsApp.Migrations
{
    [DbContext(typeof(SportsAppContext))]
    partial class SportsAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsApp.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("NumOfParticipants");

                    b.Property<string>("TestType");

                    b.HasKey("TestId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("SportsApp.Models.TestDetails", b =>
                {
                    b.Property<int>("AthleteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AthleteName");

                    b.Property<decimal>("Distance");

                    b.Property<string>("MyProperty");

                    b.Property<int>("TestId");

                    b.HasKey("AthleteId");

                    b.ToTable("TestDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
