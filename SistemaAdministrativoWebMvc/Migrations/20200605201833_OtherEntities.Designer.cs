﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaAdministrativoWebMvc.Models.Data;

namespace SistemaAdministrativoWebMvc.Migrations
{
    [DbContext(typeof(SisAdminMvcContext))]
    [Migration("20200605201833_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SistemaAdministrativoWebMvc.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("SistemaAdministrativoWebMvc.Models.RegistroVendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("RegistroVendas");
                });

            modelBuilder.Entity("SistemaAdministrativoWebMvc.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("SalarioBase")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("SistemaAdministrativoWebMvc.Models.RegistroVendas", b =>
                {
                    b.HasOne("SistemaAdministrativoWebMvc.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("SistemaAdministrativoWebMvc.Models.Vendedor", b =>
                {
                    b.HasOne("SistemaAdministrativoWebMvc.Models.Departamento", "Departamento")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
