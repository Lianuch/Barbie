﻿// <auto-generated />
using System;
using Barbie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Barbie.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240417162517_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Barbie.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkSchedule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Barbie.Models.Barber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BarberClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("BarberIncome")
                        .HasColumnType("real");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Barbers");
                });

            modelBuilder.Entity("Barbie.Models.BarberBarbershop", b =>
                {
                    b.Property<Guid>("BarberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BarbershopId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BarberId", "BarbershopId");

                    b.HasIndex("BarbershopId");

                    b.ToTable("BarberBarbershops");
                });

            modelBuilder.Entity("Barbie.Models.Barbershop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Barbershops");
                });

            modelBuilder.Entity("Barbie.Models.BarbershopClient", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BarbershopId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClientId", "BarbershopId");

                    b.HasIndex("BarbershopId");

                    b.ToTable("BarbershopClients");
                });

            modelBuilder.Entity("Barbie.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Barbie.Models.HaircutType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HairType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HaircutTypes");
                });

            modelBuilder.Entity("Barbie.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BarbershopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BarbershopId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Barbie.Models.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BarberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HaircutTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("BarberId");

                    b.HasIndex("ClientId");

                    b.HasIndex("HaircutTypeId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("Barbie.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BarberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("BarberId");

                    b.HasIndex("ClientId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Barbie.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Barbie.Models.Admin", b =>
                {
                    b.HasOne("Barbie.Models.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("Barbie.Models.Admin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Barbie.Models.Barber", b =>
                {
                    b.HasOne("Barbie.Models.User", "User")
                        .WithOne("Barber")
                        .HasForeignKey("Barbie.Models.Barber", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Barbie.Models.BarberBarbershop", b =>
                {
                    b.HasOne("Barbie.Models.Barber", "Barber")
                        .WithMany("BarberBarbershops")
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbie.Models.Barbershop", "Barbershop")
                        .WithMany("BarberBarbershops")
                        .HasForeignKey("BarbershopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barber");

                    b.Navigation("Barbershop");
                });

            modelBuilder.Entity("Barbie.Models.BarbershopClient", b =>
                {
                    b.HasOne("Barbie.Models.Barbershop", "Barbershop")
                        .WithMany("BarbershopClients")
                        .HasForeignKey("BarbershopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbie.Models.Client", "Client")
                        .WithMany("BarbershopClients")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbershop");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Barbie.Models.Client", b =>
                {
                    b.HasOne("Barbie.Models.User", "User")
                        .WithOne("Client")
                        .HasForeignKey("Barbie.Models.Client", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Barbie.Models.Location", b =>
                {
                    b.HasOne("Barbie.Models.Barbershop", "Barbershop")
                        .WithOne("Location")
                        .HasForeignKey("Barbie.Models.Location", "BarbershopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbershop");
                });

            modelBuilder.Entity("Barbie.Models.Record", b =>
                {
                    b.HasOne("Barbie.Models.Admin", "Admin")
                        .WithMany("Records")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("Barbie.Models.Barber", "Barber")
                        .WithMany("Records")
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("Barbie.Models.Client", "Client")
                        .WithMany("Records")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("Barbie.Models.HaircutType", "HaircutType")
                        .WithMany("Records")
                        .HasForeignKey("HaircutTypeId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Barber");

                    b.Navigation("Client");

                    b.Navigation("HaircutType");
                });

            modelBuilder.Entity("Barbie.Models.Review", b =>
                {
                    b.HasOne("Barbie.Models.Admin", "Admin")
                        .WithMany("Reviews")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbie.Models.Barber", "Barber")
                        .WithMany("Reviews")
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("Barbie.Models.Client", "Client")
                        .WithMany("Reviews")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Barber");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Barbie.Models.Admin", b =>
                {
                    b.Navigation("Records");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Barbie.Models.Barber", b =>
                {
                    b.Navigation("BarberBarbershops");

                    b.Navigation("Records");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Barbie.Models.Barbershop", b =>
                {
                    b.Navigation("BarberBarbershops");

                    b.Navigation("BarbershopClients");

                    b.Navigation("Location")
                        .IsRequired();
                });

            modelBuilder.Entity("Barbie.Models.Client", b =>
                {
                    b.Navigation("BarbershopClients");

                    b.Navigation("Records");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Barbie.Models.HaircutType", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("Barbie.Models.User", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Barber");

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
