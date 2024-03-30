﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheSku.Data;

#nullable disable

namespace TheSku.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("creation");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<string>("Owner")
                        .HasColumnType("longtext")
                        .HasColumnName("owner");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("supplier_name");

                    b.HasKey("Name");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<Guid>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Name");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
