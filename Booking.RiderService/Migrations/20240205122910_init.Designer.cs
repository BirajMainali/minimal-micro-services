﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RiderService.Data;

#nullable disable

namespace RiderService.Migrations
{
    [DbContext(typeof(RiderServiceDbContext))]
    [Migration("20240205122910_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RiderService.Models.RiderConfirmation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime?>("ConfirmedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("confirmeddate");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("isconfirmed");

                    b.Property<string>("Rider")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rider");

                    b.HasKey("Id")
                        .HasName("pk_riderequests");

                    b.ToTable("riderequests", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
