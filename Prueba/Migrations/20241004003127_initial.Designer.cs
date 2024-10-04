﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba.Data;

#nullable disable

namespace Prueba.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241004003127_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prueba.Entities.Cliente", b =>
                {
                    b.Property<int>("N_Documento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("N_Documento"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Motivo_hospedaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Parqueadero")
                        .HasColumnType("bit");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Tipo_Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("N_Documento");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Prueba.Entities.Cuarto", b =>
                {
                    b.Property<int>("Numero_Cuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero_Cuarto"));

                    b.Property<int>("N_Documento")
                        .HasColumnType("int");

                    b.HasKey("Numero_Cuarto");

                    b.HasIndex("N_Documento");

                    b.ToTable("Cuartos");
                });

            modelBuilder.Entity("Prueba.Entities.Historia_Cliente", b =>
                {
                    b.Property<int>("ID_Historia")
                        .HasColumnType("int");

                    b.Property<int>("N_Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("F_entrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_salida")
                        .HasColumnType("datetime2");

                    b.Property<int>("N_Historia_cuarto")
                        .HasColumnType("int");

                    b.Property<int>("N_T_Lavanderia")
                        .HasColumnType("int");

                    b.Property<int>("N_Visitas")
                        .HasColumnType("int");

                    b.HasKey("ID_Historia", "N_Documento");

                    b.HasIndex("N_Documento");

                    b.ToTable("Historia_Clientes");
                });

            modelBuilder.Entity("Prueba.Entities.Lavanderia", b =>
                {
                    b.Property<int>("Id_Lavanderia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Lavanderia"));

                    b.Property<int>("N_Cuarto")
                        .HasColumnType("int");

                    b.Property<int>("N_Servicios")
                        .HasColumnType("int");

                    b.HasKey("Id_Lavanderia");

                    b.ToTable("Lavanderias");
                });

            modelBuilder.Entity("Prueba.Entities.Cuarto", b =>
                {
                    b.HasOne("Prueba.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("N_Documento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Prueba.Entities.Historia_Cliente", b =>
                {
                    b.HasOne("Prueba.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("N_Documento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
