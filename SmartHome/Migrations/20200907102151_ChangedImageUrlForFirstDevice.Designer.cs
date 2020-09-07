﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHome.Models;

namespace SmartHome.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200907102151_ChangedImageUrlForFirstDevice")]
    partial class ChangedImageUrlForFirstDevice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartHome.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeviceId");

                    b.HasIndex("SectionId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = 1,
                            ImageThumbnailUrl = "~/Images/bulb.png",
                            ImageUrl = "~/Images/bulb.png",
                            IsNew = true,
                            Name = "Lighting source",
                            Price = 0m,
                            SectionId = 1,
                            ShortDescription = "Lighting source for instance - LED"
                        },
                        new
                        {
                            DeviceId = 2,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            IsNew = true,
                            Name = "Pump",
                            Price = 0m,
                            SectionId = 2,
                            ShortDescription = "Pump that allows water flow"
                        },
                        new
                        {
                            DeviceId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                            IsNew = false,
                            Name = "Roller blind",
                            Price = 0m,
                            SectionId = 3,
                            ShortDescription = "Roller blind that allows window covering"
                        });
                });

            modelBuilder.Entity("SmartHome.Models.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionId");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            SectionId = 1,
                            Description = "Lighting",
                            SectionName = "Electricity"
                        },
                        new
                        {
                            SectionId = 2,
                            Description = "Heating and Air conditioning",
                            SectionName = "HVAC"
                        },
                        new
                        {
                            SectionId = 3,
                            Description = "Rest od controlled devices",
                            SectionName = "Others"
                        });
                });

            modelBuilder.Entity("SmartHome.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("DeviceId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("SmartHome.Models.Device", b =>
                {
                    b.HasOne("SmartHome.Models.Section", "Section")
                        .WithMany("Devices")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartHome.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("SmartHome.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");
                });
#pragma warning restore 612, 618
        }
    }
}
