﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo.Data;

#nullable disable

namespace Todo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Todo.Models.TodoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SubHeader")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("SubmissionsDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TodoList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Don't forget to revise",
                            DueDate = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Header = "Test",
                            SubHeader = "Test in Physics",
                            SubmissionsDate = new DateTime(2024, 2, 22, 2, 17, 7, 418, DateTimeKind.Local).AddTicks(6631)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Don't forget to revise",
                            DueDate = new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Header = "Test",
                            SubHeader = "Test in Chemistry",
                            SubmissionsDate = new DateTime(2024, 2, 22, 2, 17, 7, 418, DateTimeKind.Local).AddTicks(6802)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}