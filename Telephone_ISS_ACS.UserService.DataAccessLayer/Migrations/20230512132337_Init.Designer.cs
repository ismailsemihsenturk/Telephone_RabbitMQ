﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Telephone_ISS_ACS.UserService.DataAccessLayer.Context;

namespace Telephone_ISS_ACS.UserService.DataAccessLayer.Migrations
{
    [DbContext(typeof(PhoneBookContext))]
    [Migration("20230512132337_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Telephone_ISS_ACS.UserService.DataAccessLayer.Entities.ContactInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PhoneBookEntryId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PhoneBookEntryId");

                    b.ToTable("ContactInformation");
                });

            modelBuilder.Entity("Telephone_ISS_ACS.UserService.DataAccessLayer.Entities.PhoneBookEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PhoneBookEntry");
                });

            modelBuilder.Entity("Telephone_ISS_ACS.UserService.DataAccessLayer.Entities.ContactInformation", b =>
                {
                    b.HasOne("Telephone_ISS_ACS.UserService.DataAccessLayer.Entities.PhoneBookEntry", "PhoneBookEntry")
                        .WithMany("ContactInformation")
                        .HasForeignKey("PhoneBookEntryId");
                });
#pragma warning restore 612, 618
        }
    }
}
