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
    [Migration("20231018143333_v8")]
    partial class v8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudySystem.Data.Entites.AddressUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descriptions")
                        .HasColumnType("text");

                    b.Property<string>("DistrictCode")
                        .HasColumnType("text");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("WardCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DistrictCode");

                    b.HasIndex("ProvinceCode");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.HasIndex("WardCode");

                    b.HasIndex("UserID", "WardCode", "DistrictCode", "ProvinceCode");

                    b.ToTable("AddressUsers");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodeNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("administrative_regions");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodeNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("administrative_units");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.District", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("AdministrativeUnitId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.Property<string>("ProvinceCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("ProvinceCode", "AdministrativeUnitId");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Province", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("AdministrativeRegionId")
                        .HasColumnType("integer");

                    b.Property<int?>("AdministrativeUnitId")
                        .HasColumnType("integer");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("AdministrativeRegionId", "AdministrativeUnitId");

                    b.ToTable("provinces");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserDetail", b =>
                {
                    b.Property<string>("UserID")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

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

                    b.HasIndex("UserID")
                        .HasDatabaseName("IX_UserDetail_UserID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserToken", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpireTimeOnline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("UserTokens");
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

            modelBuilder.Entity("StudySystem.Data.Entites.Ward", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("AdministrativeUnitId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<string>("DistrictCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("DistrictCode", "AdministrativeUnitId");

                    b.ToTable("wards");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AddressUser", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.District", "District")
                        .WithMany("AddressUsers")
                        .HasForeignKey("DistrictCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudySystem.Data.Entites.Province", "Province")
                        .WithMany("AddressUsers")
                        .HasForeignKey("ProvinceCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudySystem.Data.Entites.UserDetail", "UserDetail")
                        .WithOne("AddressUser")
                        .HasForeignKey("StudySystem.Data.Entites.AddressUser", "UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Ward", "Ward")
                        .WithMany("AddressUsers")
                        .HasForeignKey("WardCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("District");

                    b.Navigation("Province");

                    b.Navigation("UserDetail");

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.District", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Districts")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Province", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.AdministrativeRegion", "AdministrativeRegion")
                        .WithMany("Provinces")
                        .HasForeignKey("AdministrativeRegionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudySystem.Data.Entites.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Provinces")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AdministrativeRegion");

                    b.Navigation("AdministrativeUnit");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Ward", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Wards")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("District");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeRegion", b =>
                {
                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeUnit", b =>
                {
                    b.Navigation("Districts");

                    b.Navigation("Provinces");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.District", b =>
                {
                    b.Navigation("AddressUsers");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Province", b =>
                {
                    b.Navigation("AddressUsers");

                    b.Navigation("Districts");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserDetail", b =>
                {
                    b.Navigation("AddressUser");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Ward", b =>
                {
                    b.Navigation("AddressUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
