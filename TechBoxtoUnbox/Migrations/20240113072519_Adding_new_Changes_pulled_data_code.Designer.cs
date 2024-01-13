﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechBoxtoUnbox.DataAccess;

#nullable disable

namespace TechBoxtoUnbox.Migrations
{
    [DbContext(typeof(CourseContext))]
    [Migration("20240113072519_Adding_new_Changes_pulled_data_code")]
    partial class Adding_new_Changes_pulled_data_code
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<decimal>("CFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createddate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.Staff", b =>
                {
                    b.Property<int>("St_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("St_ID"));

                    b.Property<string>("St_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("St_DOE")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("St_DOJ")
                        .HasColumnType("datetime2");

                    b.Property<bool>("St_Gender")
                        .HasColumnType("bit");

                    b.Property<string>("St_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("St_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("St_ID");

                    b.ToTable("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
