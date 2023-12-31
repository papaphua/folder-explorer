﻿// <auto-generated />
using System;
using FolderExplorer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FolderExplorer.Models.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FolderExplorer.Models.Entities.Folder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentFolderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Folders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2"),
                            Name = "Creating Digital Images"
                        },
                        new
                        {
                            Id = new Guid("4955e8ab-a3f9-4d46-8432-412f15ce7956"),
                            Name = "Resources",
                            ParentFolderId = new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2")
                        },
                        new
                        {
                            Id = new Guid("a789d8d4-2708-4413-b1da-8bb727766b81"),
                            Name = "Evidence",
                            ParentFolderId = new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2")
                        },
                        new
                        {
                            Id = new Guid("b16eccef-7a17-49bb-813b-e96d539e7d57"),
                            Name = "Graphic Products",
                            ParentFolderId = new Guid("eb1c85ee-e1a6-484f-a506-01fa84d0a9a2")
                        },
                        new
                        {
                            Id = new Guid("8a403497-333b-41b8-91d3-1a1c71cb4a68"),
                            Name = "Primary Sources",
                            ParentFolderId = new Guid("4955e8ab-a3f9-4d46-8432-412f15ce7956")
                        },
                        new
                        {
                            Id = new Guid("ac5024fd-7204-40e3-89b3-aa3bc1805be2"),
                            Name = "Secondary Sources",
                            ParentFolderId = new Guid("4955e8ab-a3f9-4d46-8432-412f15ce7956")
                        },
                        new
                        {
                            Id = new Guid("bde3b420-4a76-4c84-817d-a839efe6bc98"),
                            Name = "Process",
                            ParentFolderId = new Guid("b16eccef-7a17-49bb-813b-e96d539e7d57")
                        },
                        new
                        {
                            Id = new Guid("0ebca07b-2579-4f2a-ad6c-8d6d7d61a10b"),
                            Name = "Final Product",
                            ParentFolderId = new Guid("b16eccef-7a17-49bb-813b-e96d539e7d57")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
