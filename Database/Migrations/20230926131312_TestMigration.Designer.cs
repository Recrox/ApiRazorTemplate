﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(BepContext))]
    [Migration("20230926131312_TestMigration")]
    partial class TestMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("testEfCore.Models.BudgetData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BudgetData");
                });

            modelBuilder.Entity("testEfCore.Models.FinData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ACCDS1AC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ANAACCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENVIRO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FOLDER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GENACCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERIOD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PERSON")
                        .HasColumnType("int");

                    b.Property<int?>("PROJECT")
                        .HasColumnType("int");

                    b.Property<decimal?>("REALIZED")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("FinData");
                });
#pragma warning restore 612, 618
        }
    }
}
