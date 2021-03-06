﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Service;

namespace Service.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Conductor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComprobanteDomicilio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenciaConducir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeguroSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Conductors");
                });

            modelBuilder.Entity("Models.ProcesoRevision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("HorarioSupervision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incidentes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoViajes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorId");

                    b.ToTable("ProcesoRevisions");
                });

            modelBuilder.Entity("Models.Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Supervisors");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ancho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Automovil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Combustible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConductorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("FechaExpedicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemModelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Largo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroCamion")
                        .HasColumnType("int");

                    b.Property<string>("NumeroMotor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoBusiness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vigencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConductorId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Models.ProcesoRevision", b =>
                {
                    b.HasOne("Models.Supervisor", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");
                });

            modelBuilder.Entity("Models.Vehiculo", b =>
                {
                    b.HasOne("Models.Conductor", "Conductor")
                        .WithMany()
                        .HasForeignKey("ConductorId");
                });
#pragma warning restore 612, 618
        }
    }
}
