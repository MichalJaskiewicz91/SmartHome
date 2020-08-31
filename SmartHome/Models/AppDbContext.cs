using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SmartHome.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed sections
            modelBuilder.Entity<Section>().HasData(new Section { SectionId = 1, SectionName = "Electricity", Description = "Lighting" });
            modelBuilder.Entity<Section>().HasData(new Section { SectionId = 2, SectionName = "HVAC", Description = "Heating and Air conditioning" });
            modelBuilder.Entity<Section>().HasData(new Section { SectionId = 3, SectionName = "Others", Description = "Rest od controlled devices" });

            //seed devices

            modelBuilder.Entity<Device>().HasData(new Device
            {
                DeviceId = 1,
                Name = "Lighting source",
                ShortDescription = "Lighting source for instance - LED",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                IsNew = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
            });

            modelBuilder.Entity<Device>().HasData(new Device
            {
                DeviceId = 2,
                Name = "Pump",
                ShortDescription = "Pump that allows water flow",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                IsNew = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
            });

            modelBuilder.Entity<Device>().HasData(new Device
            {
                DeviceId = 3,
                Name = "Roller blind",
                ShortDescription = "Roller blind that allows window covering",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                IsNew = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
            });


        }

    }
}
