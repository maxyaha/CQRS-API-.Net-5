﻿// <auto-generated />
using System;
using Microservice.DataAccress.IPD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microservice.DataAccress.IPD.Migrations
{
    [DbContext(typeof(IpdStoreContext))]
    partial class IpdStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microservice.DataAccress.Entites.IPD.Models.IpdPendingCode", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("00000000-0000-0000-0000-000000000000"))
                        .HasColumnName("ID");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Code");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("DescriptionEN")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescriptionEN");

                    b.Property<string>("DescriptionTH")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescriptionTH");

                    b.Property<string>("Flag")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Flag");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ModifiedDate");

                    b.Property<int>("Version")
                        .HasColumnType("int")
                        .HasColumnName("Version");

                    b.HasKey("ID");

                    b.ToTable("IpdPendingCode");
                });

            modelBuilder.Entity("Microservice.DataAccress.Entites.IPD.Models.PendingCode", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("00000000-0000-0000-0000-000000000000"))
                        .HasColumnName("ID");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Code");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("DescriptionEN")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescriptionEN");

                    b.Property<string>("DescriptionTH")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescriptionTH");

                    b.Property<string>("Flag")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Flag");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ModifiedDate");

                    b.Property<int>("Version")
                        .HasColumnType("int")
                        .HasColumnName("Version");

                    b.HasKey("ID");

                    b.ToTable("PendingCode");
                });
#pragma warning restore 612, 618
        }
    }
}