﻿// <auto-generated />
using CoreFirstCoreF.K.DropDown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreFirstCoreF.K.DropDown.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240708065758_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreFirstCoreF.K.DropDown.Models.City", b =>
                {
                    b.Property<int>("city_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("city_id"));

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("city_id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CoreFirstCoreF.K.DropDown.Models.Department", b =>
                {
                    b.Property<int>("Did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Did"));

                    b.Property<string>("Dname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Did");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CoreFirstCoreF.K.DropDown.Models.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eid"));

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("Did")
                        .HasColumnType("int");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobileno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.HasIndex("Did");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CoreFirstCoreF.K.DropDown.Models.Employee", b =>
                {
                    b.HasOne("CoreFirstCoreF.K.DropDown.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Did")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
