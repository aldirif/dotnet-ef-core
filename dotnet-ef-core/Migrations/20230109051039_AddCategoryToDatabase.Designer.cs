﻿// <auto-generated />
using DotnetEfCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace dotnet_ef_core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230109051039_AddCategoryToDatabase")]
    partial class AddCategoryToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DotnetEfCore.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category_name");

                    b.Property<string>("Decription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });
#pragma warning restore 612, 618
        }
    }
}
