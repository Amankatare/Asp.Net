﻿// <auto-generated />
using MVC2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231226063333_init3")]
    partial class init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC2.Models.Student", b =>
                {
                    b.Property<int>("RollNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RollNo"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RollNo");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            RollNo = 1,
                            Email = "john@example.com",
                            Name = "John Doe",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            RollNo = 2,
                            Email = "jane@example.com",
                            Name = "Jane Doe",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            RollNo = 3,
                            Email = "jane@example.com",
                            Name = "Jane Doe",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            RollNo = 4,
                            Email = "alice@example.com",
                            Name = "Alice Smith",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            RollNo = 5,
                            Email = "bob@example.com",
                            Name = "Bob Johnson",
                            PhoneNumber = "888-555-1234"
                        },
                        new
                        {
                            RollNo = 6,
                            Email = "eva@example.com",
                            Name = "Eva Martinez",
                            PhoneNumber = "777-888-9999"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
