﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheSku.Data;

#nullable disable

namespace TheSku.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240407081023_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Docstatus")
                        .HasColumnType("int")
                        .HasColumnName("docstatus");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<string>("Owner")
                        .HasColumnType("longtext")
                        .HasColumnName("owner");

                    b.Property<string>("Parent")
                        .HasColumnType("longtext")
                        .HasColumnName("parent");

                    b.Property<string>("ParentField")
                        .HasColumnType("longtext")
                        .HasColumnName("parentfield");

                    b.Property<string>("ParentType")
                        .HasColumnType("longtext")
                        .HasColumnName("parenttype");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("supplier_name");

                    b.HasKey("Name");

                    b.ToTable("tabSupplier");
                });

            modelBuilder.Entity("SupplierGroup", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("creation");

                    b.Property<int>("Docstatus")
                        .HasColumnType("int")
                        .HasColumnName("docstatus");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<string>("Owner")
                        .HasColumnType("longtext")
                        .HasColumnName("owner");

                    b.Property<string>("Parent")
                        .HasColumnType("longtext")
                        .HasColumnName("parent");

                    b.Property<string>("ParentField")
                        .HasColumnType("longtext")
                        .HasColumnName("parentfield");

                    b.Property<string>("ParentType")
                        .HasColumnType("longtext")
                        .HasColumnName("parenttype");

                    b.Property<string>("SupplierGroupName")
                        .HasColumnType("longtext")
                        .HasColumnName("supplier_group_name");

                    b.HasKey("Name");

                    b.ToTable("tabSupplier Group");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("creation");

                    b.Property<int>("Docstatus")
                        .HasColumnType("int")
                        .HasColumnName("docstatus");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext")
                        .HasColumnName("full_name");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<string>("Owner")
                        .HasColumnType("longtext")
                        .HasColumnName("owner");

                    b.Property<string>("Parent")
                        .HasColumnType("longtext")
                        .HasColumnName("parent");

                    b.Property<string>("ParentField")
                        .HasColumnType("longtext")
                        .HasColumnName("parentfield");

                    b.Property<string>("ParentType")
                        .HasColumnType("longtext")
                        .HasColumnName("parenttype");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Name");

                    b.ToTable("tabUser");
                });
#pragma warning restore 612, 618
        }
    }
}
