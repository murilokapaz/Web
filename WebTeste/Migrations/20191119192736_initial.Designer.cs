﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTeste.Models;

namespace WebTeste.Migrations
{
    [DbContext(typeof(WebTesteContext))]
    [Migration("20191119192736_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebTeste.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("SellersId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellersId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("WebTeste.Models.Sellers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("BaseSalary")
                        .HasColumnType("double");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("WebTeste.Models.ViewModels.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebTeste.Models.SalesRecord", b =>
                {
                    b.HasOne("WebTeste.Models.Sellers", null)
                        .WithMany("SalesRecord")
                        .HasForeignKey("SellersId");
                });

            modelBuilder.Entity("WebTeste.Models.Sellers", b =>
                {
                    b.HasOne("WebTeste.Models.ViewModels.Department", null)
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}