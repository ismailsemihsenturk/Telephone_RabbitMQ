﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Telephone_ISS_ACS.ReportService.DataAccessLayer.Context;

namespace Telephone_ISS_ACS.ReportService.DataAccessLayer.Migrations
{
    [DbContext(typeof(ReportContext))]
    partial class ReportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Telephone_ISS_ACS.ReportService.DataAccessLayer.Entities.ReportDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumberCount")
                        .HasColumnType("integer");

                    b.Property<int>("UserCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Report");
                });
#pragma warning restore 612, 618
        }
    }
}
