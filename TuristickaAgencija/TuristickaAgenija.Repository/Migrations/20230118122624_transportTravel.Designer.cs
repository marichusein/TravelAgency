﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuristickaAgenija.Repository;

#nullable disable

namespace Repository.TuristickaAgenija.Migrations
{
    [DbContext(typeof(TuristickaAgencijaDbContext))]
    [Migration("20230118122624_transportTravel")]
    partial class transportTravel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Accommodation", b =>
                {
                    b.Property<int>("AccommodationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccommodationID"));

                    b.Property<int>("DestinationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<bool>("Pass")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("AccommodationID");

                    b.HasIndex("DestinationID");

                    b.ToTable("Accommodation");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationID"));

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Describe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("DestinationID");

                    b.HasIndex("CityID");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Transportation", b =>
                {
                    b.Property<int>("TransportationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransportationId"));

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("TransportationId");

                    b.ToTable("Transportation");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.TravelArrangement", b =>
                {
                    b.Property<int>("TravelArrangementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TravelArrangementID"));

                    b.Property<int>("AccommodationID")
                        .HasColumnType("int");

                    b.Property<int>("DestinationID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfPerson")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TransportationId")
                        .HasColumnType("int");

                    b.Property<int>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("TravelArrangementID");

                    b.HasIndex("AccommodationID");

                    b.HasIndex("DestinationID");

                    b.HasIndex("TransportationId");

                    b.HasIndex("UsersID");

                    b.ToTable("TravelArrangement");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsersID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsersID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Accommodation", b =>
                {
                    b.HasOne("Core.TuristickaAgencija.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.City", b =>
                {
                    b.HasOne("Core.TuristickaAgencija.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.Destination", b =>
                {
                    b.HasOne("Core.TuristickaAgencija.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.TuristickaAgencija.Models.TravelArrangement", b =>
                {
                    b.HasOne("Core.TuristickaAgencija.Models.Accommodation", "Accommodation")
                        .WithMany()
                        .HasForeignKey("AccommodationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.TuristickaAgencija.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.TuristickaAgencija.Models.Transportation", "Transportation")
                        .WithMany()
                        .HasForeignKey("TransportationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.TuristickaAgencija.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accommodation");

                    b.Navigation("Destination");

                    b.Navigation("Transportation");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}