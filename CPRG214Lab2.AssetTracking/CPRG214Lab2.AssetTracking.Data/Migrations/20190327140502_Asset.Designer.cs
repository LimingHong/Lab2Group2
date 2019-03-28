﻿// <auto-generated />
using CPRG214Lab2.AssetTracking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPRG214Lab2.AssetTracking.Data.Migrations
{
    [DbContext(typeof(AssetTrackingContext))]
    [Migration("20190327140502_Asset")]
    partial class Asset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPRG214Lab2.AssetTracking.domain.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTypeId");

                    b.Property<string>("Description");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("TagNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Assets");

                    b.HasData(
                        new { Id = 1, AssetTypeId = 1, Description = "Acer Monitor MD1231", Manufacturer = "Acer", Model = "A1", SerialNumber = "ISO929", TagNumber = "MD1231" },
                        new { Id = 2, AssetTypeId = 2, Description = "LG Monitor XM1232", Manufacturer = "Dell", Model = "B2", SerialNumber = "ISO879", TagNumber = "XM1232" },
                        new { Id = 3, AssetTypeId = 3, Description = "HP Monitor BV1233", Manufacturer = "HP", Model = "C3", SerialNumber = "ISO129", TagNumber = "BV1233" },
                        new { Id = 4, AssetTypeId = 4, Description = "Avaya phone SS1234", Manufacturer = "Dell", Model = "D4", SerialNumber = "ISO212", TagNumber = "SS1234" },
                        new { Id = 5, AssetTypeId = 5, Description = "Polycom phone SS1234", Manufacturer = "HP", Model = "E5", SerialNumber = "ISO213", TagNumber = "SS1235" },
                        new { Id = 6, AssetTypeId = 6, Description = "Cisco phone SS1234", Manufacturer = "Acer", Model = "F6", SerialNumber = "ISO214", TagNumber = "SS1236" }
                    );
                });

            modelBuilder.Entity("CPRG214Lab2.AssetTracking.domain.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AssetTypes");

                    b.HasData(
                        new { Id = 1, Name = "Acer Monitor" },
                        new { Id = 2, Name = "LG Monitor" },
                        new { Id = 3, Name = "Hp Monitor" },
                        new { Id = 4, Name = "Avaya Phone" },
                        new { Id = 5, Name = "Polycom Phone" },
                        new { Id = 6, Name = "Cisco Phone" }
                    );
                });

            modelBuilder.Entity("CPRG214Lab2.AssetTracking.domain.Asset", b =>
                {
                    b.HasOne("CPRG214Lab2.AssetTracking.domain.AssetType", "AssetType")
                        .WithMany("Asset")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
