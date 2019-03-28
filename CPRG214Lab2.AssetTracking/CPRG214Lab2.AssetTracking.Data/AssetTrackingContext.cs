using CPRG214Lab2.AssetTracking.domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CPRG214Lab2.AssetTracking.Data
{
    public class AssetTrackingContext : DbContext
    {
        public AssetTrackingContext() : base() { }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Change the connection string here for your home computer/lab computer
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;
                                          Database=AssetTracking;
                                          Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AssetType>().HasData(
             new AssetType
             {
                 Id = 1,
                 Name = "Acer Monitor"

             },
             new AssetType
             {
                 Id = 2,
                 Name = "LG Monitor",

             },
             new AssetType
             {
                 Id = 3,
                 Name = "Hp Monitor"

             },

              new AssetType
              {
                  Id = 4,
                  Name = "Avaya Phone"

              },
               new AssetType
               {
                   Id = 5,
                   Name = "Polycom Phone"

               },
                new AssetType
                {
                    Id = 6,
                    Name = "Cisco Phone"

                }


             );
            //seed data created here
            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = 1,
                    TagNumber = "MD1231",
                    AssetTypeId = 1,
                    Manufacturer = "Acer",
                    Model = "A1",
                    Description = "Acer Monitor MD1231",
                    SerialNumber = "ISO929"
                },
                new Asset
                {
                    Id = 2,
                    TagNumber = "XM1232",
                    AssetTypeId = 2,
                    Manufacturer = "Dell",
                    Model = "B2",
                    Description = "LG Monitor XM1232",
                    SerialNumber = "ISO879"
                },
                new Asset
                {
                    Id = 3,
                    TagNumber = "BV1233",
                    AssetTypeId = 3,
                    Manufacturer = "HP",
                    Model = "C3",
                    Description = "HP Monitor BV1233",
                    SerialNumber = "ISO129"
                },
                new Asset
                {
                    Id = 4,
                    TagNumber = "SS1234",
                    AssetTypeId = 4,
                    Manufacturer = "Dell",
                    Model = "D4",
                    Description = "Avaya phone SS1234",
                    SerialNumber = "ISO212"
                },

            new Asset
            {
                Id = 5,
                TagNumber = "SS1235",
                AssetTypeId = 5,
                Manufacturer = "HP",
                Model = "E5",
                Description = "Polycom phone SS1234",
                SerialNumber = "ISO213"
            },

            new Asset
            { Id = 6,
                TagNumber = "SS1236",
                AssetTypeId = 6,
                Manufacturer = "Acer",
                Model = "F6",
                Description = "Cisco phone SS1234",
                SerialNumber = "ISO214"
            }
                );

         
        }

    }
}
