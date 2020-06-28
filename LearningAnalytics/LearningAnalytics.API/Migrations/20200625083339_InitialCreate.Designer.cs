﻿// <auto-generated />
using LearningAnalytics.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearningAnalytics.API.Migrations
{
    [DbContext(typeof(LearningAnalyticsAPIContext))]
    [Migration("20200625083339_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LearningAnalytics.API.Model.Cohort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cohort");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "2018/2019",
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            DisplayName = "2019/2020",
                            Year = 2019
                        },
                        new
                        {
                            Id = 3,
                            DisplayName = "2020/2021",
                            Year = 2020
                        });
                });

            modelBuilder.Entity("LearningAnalytics.API.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CohortId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Registration")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CohortId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CohortId = 1,
                            FirstName = "William",
                            Surname = "Shakespeare"
                        });
                });

            modelBuilder.Entity("LearningAnalytics.API.Model.Student", b =>
                {
                    b.HasOne("LearningAnalytics.API.Model.Cohort", null)
                        .WithMany("Students")
                        .HasForeignKey("CohortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
