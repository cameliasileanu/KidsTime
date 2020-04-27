using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        public DbSet<Activity>  Activities { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Sport", Description="Sport" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Tehnica", Description = "Tehnica" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Arta", Description = "Arta" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Cultura", Description = "Description" });

            //seed pies
            modelBuilder.Entity<Activity>().HasData(new  Activity
            {
                ActivityId = 1,
                Name = "Pictura",
                Price = 20,
                ShortDescription = "Viata in culori",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 3,
                ImageURl = "https://cdn.pixabay.com/photo/2019/05/24/16/49/brushes-4226688_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2019/05/24/16/49/brushes-4226688_1280.jpg",             
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 2,
                Name = "Vioara",
                Price = 20,
                ShortDescription = "Viata intre vibratii",
                LongDescription =
                   "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 3,
                ImageURl = "https://cdn.pixabay.com/photo/2016/08/24/20/39/violin-1617972_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2016/08/24/20/39/violin-1617972_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 3,
                Name = "Dansuri populare",
                Price = 20,
                ShortDescription = "Ne conectam cu bunnii si strabunii",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 3,
                ImageURl = "https://cdn.pixabay.com/photo/2018/05/12/15/13/amateur-3393588_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2018/05/12/15/13/amateur-3393588_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 4,
                Name = "Teatru",
                Price = 20,
                ShortDescription = "Teatru de revista",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 3,
                ImageURl = "https://cdn.pixabay.com/photo/2017/09/03/16/16/musical-2710927_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2017/09/03/16/16/musical-2710927_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 5,
                Name = "Ceramica",
                Price = 20,
                ShortDescription = "Dam viata lutului",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 3,
                ImageURl = "https://cdn.pixabay.com/photo/2015/02/03/16/14/potter-622708_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2015/02/03/16/14/potter-622708_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 6,
                Name = "Japonia",
                Price = 20,
                ShortDescription = "Cultura si civilizatia Japoniei",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 4,
                ImageURl = "https://cdn.pixabay.com/photo/2015/09/21/15/10/geisha-949978_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2015/09/21/15/10/geisha-949978_1280.jpg",
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 7,
                Name = "Grecia",
                Price = 20,
                ShortDescription = "Cultura si civilizatia Greciei",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 4,
                ImageURl = "https://cdn.pixabay.com/photo/2016/08/15/08/22/greece-1594689_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2016/08/15/08/22/greece-1594689_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 8,
                Name = "Karting",
                Price = 20,
                ShortDescription = "Simte viteza",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 1,
                ImageURl = "https://cdn.pixabay.com/photo/2020/04/07/09/07/go-kart-5012595_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2020/04/07/09/07/go-kart-5012595_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 9,
                Name = "Patinaj viteza",
                Price = 20,
                ShortDescription = "Sa invartim rotile",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 1,
                ImageURl = "https://cdn.pixabay.com/photo/2013/05/20/05/19/rollerderby-112223_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2013/05/20/05/19/rollerderby-112223_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 10,
                Name = "Matematica aplicata",
                Price = 20,
                ShortDescription = "Sa invartim rotile",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 2,
                ImageURl = "https://cdn.pixabay.com/photo/2016/06/13/08/00/pi-1453839_1280.jpg",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://cdn.pixabay.com/photo/2016/06/13/08/00/pi-1453839_1280.jpg",
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                ActivityId = 11,
                Name = "Aeromodele",
                Price = 20,
                ShortDescription = "Sa coboram rotile",
                LongDescription =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoryId = 1,
                ImageURl = "https://scontent.fotp3-3.fna.fbcdn.net/v/t1.0-9/10676376_749670175148758_8086599348838060691_n.jpg?_nc_cat=108&_nc_sid=85a577&_nc_ohc=DxyQnDW55NcAX_D8i_S&_nc_ht=scontent.fotp3-3.fna&oh=3cb0b394586a2aa7cf77dc591efa775e&oe=5EB58729",
                IsAvailable = true,
                IsActivityStar = true,
                ImageThumbnailURl = "https://scontent.fotp3-3.fna.fbcdn.net/v/t1.0-9/10676376_749670175148758_8086599348838060691_n.jpg?_nc_cat=108&_nc_sid=85a577&_nc_ohc=DxyQnDW55NcAX_D8i_S&_nc_ht=scontent.fotp3-3.fna&oh=3cb0b394586a2aa7cf77dc591efa775e&oe=5EB58729",
            });
        }
    }
}
