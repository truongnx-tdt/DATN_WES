﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudySystem.Data.EF;

#nullable disable

namespace StudySystem.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230918113222_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudySystem.Data.Entites.ApplicationUserToken", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpireTimeOnline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserDetail", b =>
                {
                    b.Property<string>("UserID")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.VerificationOTP", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserID");

                    b.ToTable("VerificationOTPs");
                });
#pragma warning restore 612, 618
        }
    }
}
