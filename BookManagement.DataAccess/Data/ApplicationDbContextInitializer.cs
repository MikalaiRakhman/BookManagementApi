using BookManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.DataAccess.Data
{
    public class ApplicationDbContextInitializer
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Title = "The Enchanted Forest",
                    AuthorName = "Sophia Brown",
                    PublicationYear = 2020,
                    ViewsCount = 10,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Lost in Time",
                    AuthorName = "James Williams",
                    PublicationYear = 2018,
                    ViewsCount = 25,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Hidden Treasures",
                    AuthorName = "Emily Clark",
                    PublicationYear = 2021,
                    ViewsCount = 15,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Journey to the Unknown",
                    AuthorName = "Michael Johnson",
                    PublicationYear = 2019,
                    ViewsCount = 30,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Mystery of the Old Mansion",
                    AuthorName = "Olivia Martinez",
                    PublicationYear = 2022,
                    ViewsCount = 40,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Last Expedition",
                    AuthorName = "William Davis",
                    PublicationYear = 2015,
                    ViewsCount = 50,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Secret of the Ancient Ruins",
                    AuthorName = "Mia Robinson",
                    PublicationYear = 2017,
                    ViewsCount = 60,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Great Adventure",
                    AuthorName = "Ethan Thompson",
                    PublicationYear = 2020,
                    ViewsCount = 70,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Beyond the Horizon",
                    AuthorName = "Isabella Lee",
                    PublicationYear = 2021,
                    ViewsCount = 80,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Forbidden Island",
                    AuthorName = "Benjamin Harris",
                    PublicationYear = 2016,
                    ViewsCount = 90,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Legends of the Past",
                    AuthorName = "Charlotte Wilson",
                    PublicationYear = 2019,
                    ViewsCount = 100,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Lost Kingdom",
                    AuthorName = "Henry Lewis",
                    PublicationYear = 2018,
                    ViewsCount = 110,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Tales from the Deep",
                    AuthorName = "Grace Walker",
                    PublicationYear = 2021,
                    ViewsCount = 120,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Secrets of the Moon",
                    AuthorName = "Liam Hall",
                    PublicationYear = 2022,
                    ViewsCount = 130,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Forgotten Realm",
                    AuthorName = "Ava Young",
                    PublicationYear = 2017,
                    ViewsCount = 140,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "Guardians of the Galaxy",
                    AuthorName = "Alexander King",
                    PublicationYear = 2016,
                    ViewsCount = 150,
                    IsDeleted = false
                },
                new Book
                {
                    Title = "The Phantom Ship",
                    AuthorName = "Harper Scott",
                    PublicationYear = 2020,
                    ViewsCount = 160,
                    IsDeleted = false
                }
            );
        }
    }
}
