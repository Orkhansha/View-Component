

using EntityFrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Footer> Footers { get; set; }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Header>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Footer>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Blog>().HasData(
                    new Blog
                    {
                        Id = 1,
                        IsDeleted = false,
                        Title = "Blog1",
                        Desc = "Desc1",
                        Image = "blog-feature-img-1.jpg",
                        Date = DateTime.Now
                    },
                    new Blog
                    {
                        Id = 2,
                        IsDeleted = false,
                        Title = "Blog2",
                        Desc = "Desc2",
                        Image = "blog-feature-img-3.jpg",
                        Date = DateTime.Now
                    },
                    new Blog
                    {
                        Id = 3,
                        IsDeleted = false,
                        Title = "Blog3",
                        Desc = "Desc3",
                        Image = "blog-feature-img-4.jpg",
                        Date = DateTime.Now
                    }

            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting
                {
                    Id = 1,
                    IsDeleted = false,
                    Key = "HeaderLogo",
                    Value= "logo.png"

                },
                new Setting
                {
                    Id = 2,
                    IsDeleted = false,
                    Key = "Phone",
                    Value = "535462453645"
                },
                new Setting
                {
                    Id = 3,
                    IsDeleted = false,
                    Key = "ProductTake",
                    Value = "4"
                },
                new Setting
                {
                    Id = 4,
                    IsDeleted = false,
                    Key = "Email",
                    Value = "p130@code.edu.az"
                }
                );

                modelBuilder.Entity<Header>().HasData(
                    new Header
                    {
                        Id = 1,
                        IsDeleted = false,
                        Logo = "logo.png",
                    }
                    

           );

            modelBuilder.Entity<Footer>().HasData(
                   new Footer
                   {
                       Id = 1,
                       IsDeleted = false,
                       Links = "https://www.facebook.com/cenab.akberoff",
                   },
                   new Footer
                   {
                       Id = 2,
                       IsDeleted = false,
                       Links = "https://www.instagram.com/cenab.akberoff/",
                   },
                   new Footer
                   {
                       Id = 3,
                       IsDeleted = false,
                       Links = "https://www.instagram.com/cenab.akberoff/",
                   }


          );
        }


    }
}
