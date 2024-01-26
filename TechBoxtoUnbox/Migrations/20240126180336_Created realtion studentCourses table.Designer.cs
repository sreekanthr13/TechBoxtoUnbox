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
    [Migration("20240126180336_Created realtion studentCourses table")]
    partial class CreatedrealtionstudentCoursestable
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

                    b.Property<double>("CFee")
                        .HasColumnType("float");

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

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.Student", b =>
                {
                    b.Property<int>("Student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Student_Id"));

                    b.Property<string>("Student_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Student_Age")
                        .HasColumnType("int");

                    b.Property<string>("Student_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Student_Gneder")
                        .HasColumnType("bit");

                    b.Property<string>("Student_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Resume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.StudentCourses", b =>
                {
                    b.Property<int>("StdCrs_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StdCrs_Id"));

                    b.Property<int>("Course_id")
                        .HasColumnType("int");

                    b.Property<int>("Student_Id")
                        .HasColumnType("int");

                    b.HasKey("StdCrs_Id");

                    b.HasIndex("Course_id");

                    b.HasIndex("Student_Id");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.StudentCourses", b =>
                {
                    b.HasOne("TechBoxtoUnbox.Models.DTO.Course", "course")
                        .WithMany("Studentcourses")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBoxtoUnbox.Models.DTO.Student", "student")
                        .WithMany("Studentcourses")
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.Course", b =>
                {
                    b.Navigation("Studentcourses");
                });

            modelBuilder.Entity("TechBoxtoUnbox.Models.DTO.Student", b =>
                {
                    b.Navigation("Studentcourses");
                });
#pragma warning restore 612, 618
        }
    }
}